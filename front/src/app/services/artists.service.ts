import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { BehaviorSubject, Observable, catchError, combineLatest, debounceTime, from, map, of, shareReplay, startWith, switchMap, tap } from 'rxjs';
import { FormControl } from '@angular/forms';
import { ArtistDeleteResponse, ArtistsCountResponse, ArtistsGetPageResponse, GetArtistByIdResponse } from '../models/artist';
import { toSignal } from '@angular/core/rxjs-interop';
import { GetMoodsResponse } from '../models/mood';
import { CheckRelationsArtistStyleByStyleResponse, RelationsArtistStyleForm } from '../models/relations';
import { BaseResponse } from '../models/base-response';
import { ArtistCreateForm, StyleCreateForm } from '../models/forms-create';
import { GetAllStylesResponse, GetStyleByIdResponse, StyleLight } from '../models/style';
import { CreateArtistResponse, CreateStyleResponse } from '../models/responses-create';

@Injectable({
  providedIn: 'root'
})
export class ArtistsStateService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  // Triggers
  #stylesUpdated = new BehaviorSubject<boolean>(true)
  #artistsUpdated = new BehaviorSubject<boolean>(true)
  artistUpdateTrigger(){this.#artistsUpdated.next(true)}

  // Name Search Field
  nameSearchField = new FormControl('')

  #selectedStyleId = new BehaviorSubject<number | null>(null)
  selectedStyleId$ = this.#selectedStyleId.asObservable()
  updateCurrentStyleId( styleId : number | null ) { this.#selectedStyleId.next( styleId ) }

  #startId = new BehaviorSubject<number | null>(null)
  startId$ = this.#startId.asObservable()
  updateStartId( startId : number | null ) { this.#startId.next( startId ) }

  styles$ = this.#stylesUpdated.pipe(
    switchMap(() => this.#http.get<GetAllStylesResponse>(`${this.#url}Styles/GetAll`)),
    map(response => response.styles),
    catchError(() => of([])),
    shareReplay(1)
  )

  styleDetails$ = this.selectedStyleId$.pipe(
    switchMap(styleId => 
    {
      if (styleId === null) return of(null);
      return this.#http.get<GetStyleByIdResponse>(`${this.#url}Styles/GetOneDetails/${styleId}`).pipe(
        map(response => response.style),
        catchError(() => of(null))
      )
    }),
  )

  relationsByStyle$ = this.selectedStyleId$.pipe(
    switchMap(styleId => 
    {
      if (styleId === null) return of(null)
      return this.#http.get<CheckRelationsArtistStyleByStyleResponse>(`${this.#url}Relations/ArtistStyle/CheckRelationsByStyle?styleId=${styleId}`).pipe(
        catchError(() => of(null))
      )
    }),
  )
  
  totalArtists$ = this.#artistsUpdated.pipe(
    switchMap( () => {
      return this.#http.get<ArtistsCountResponse>(this.#url + 'Artists/Count').pipe(
        map(response => response.artistsCount)
      )
    })
  )

  styleFlow$ = combineLatest([this.styleDetails$, this.relationsByStyle$]).pipe(
    map(([style, relations]) => ({ style, relations })),
    catchError(() => of({ style: null, relations: null })),
    startWith({ style: undefined, relations: null })
  )
  styleFlow = toSignal(this.styleFlow$, { initialValue: { style: undefined, relations: null } })

  artistsFlow$ = combineLatest([
    this.#artistsUpdated.pipe(startWith(true)),
    this.selectedStyleId$,
    this.nameSearchField.valueChanges.pipe(startWith('')),
    this.startId$.pipe(startWith(null)),
    this.styles$.pipe(startWith([])),
    this.totalArtists$
  ]).pipe(
    debounceTime(100),
    switchMap(([updated, styleId, searchTerm, startId, styles, totalArtists]) => {
      let params = new HttpParams()
        .set('styleId', styleId?.toString() ?? '')
        .set('startId', startId?.toString() ?? '')
        .set('abc', searchTerm || '')
        .set('pageSize', '20');
  
      return this.#http.get<ArtistsGetPageResponse>(`${this.#url}Artists/GetPage`, { params }).pipe(
        map(response => ({
          ...response,
          selectedStyleId: styleId,
          styles,
          totalArtists
        })),
        catchError(error => of({
          success: false,
          message: 'Failed to load artists and styles.' + error,
          validationErrors: [],
          totalItems: 0,
          itemPosition: 0,
          previousId: 0,
          nextId: 0,
          artistsPage: [],
          styles: [],
          selectedStyleId: null,
          totalArtists: 0
        }))
      );
    }),
    startWith({ // Valeur initiale pour que le composant ait des données immédiatement après abonnement
      success: true,
      message: '',
      validationErrors: [],
      totalItems: 0,
      itemPosition: 0,
      previousId: 0,
      nextId: 0,
      artistsPage: [],
      styles: [],
      selectedStyleId: null,
      totalArtists: 0
    }),
    shareReplay(1)
  );
  
  artistsFlow = toSignal(this.artistsFlow$, 
  {
    initialValue: {
      success: true,
      message: '',
      validationErrors: [],
      totalItems: 0,
      itemPosition: 0,
      previousId: 0,
      nextId: 0,
      artistsPage: [],
      styles: [],
      selectedStyleId: null,
      totalArtists : 0
    }
  })

  #selectedArtistId = new BehaviorSubject<number | null>(null)
  selectedArtistId$ = this.#selectedArtistId.asObservable()
  updateSelectedArtistId( artistId : number | null ) : void { this.#selectedArtistId.next(artistId) }

  artistFlow$ = this.selectedArtistId$.pipe(
    switchMap(artistId => {
      if (artistId === null) 
        {
        return of(null)
      } 
      else 
      {
        return combineLatest([
          this.GetOneDetails(artistId),
          this.GetMoodsByArtist(artistId),
        ]).pipe(
          map(([artist, moods]) => ({
            artist: artist,
            moods: moods,
          }))
        )
      }
    })
  )
  artistFlow = toSignal(this.artistFlow$)

  public GetOneDetails( artistId : number )
  {
    return this.#http.get<GetArtistByIdResponse>(`${this.#url}Artists/GetOneDetails/${artistId}`).pipe(
      map(response => response.artist))
  }

  public GetMoodsByArtist( artistId : number )
  {
    return this.#http.get<GetMoodsResponse>(this.#url + 'Moods/GetByArtist/' + artistId).pipe(
      map(response => response.moods))
  }

  // Create Artist
  public CreateArtist(formGroup: ArtistCreateForm): Observable<CreateArtistResponse> {
    let styleIds: number[] = formGroup.styles.filter(style => style.isChecked).map(style => style.businessId)
    let createForm: ArtistCreateForm = { name: formGroup.name, description : formGroup.description, styles : [] }
  
    return this.#http.post<CreateArtistResponse>(`${this.#url}Artists/Create`, createForm).pipe(
      switchMap(response => {
        this.updateSelectedArtistId(response.artistId)
        this.#artistsUpdated.next(true)
  
        if (styleIds.length > 0) {
          let rasForm: RelationsArtistStyleForm = { artistId: response.artistId, styleIds: styleIds }
          return this.InsertRAS(rasForm).pipe(
            map(() => response)
          )
        }
  
        return of(response)
      })
    )
  }

  // Update Artist
  public UpdateArtist( formGroup : ArtistCreateForm ) : Observable<CreateArtistResponse> 
  {
    let styleIds: number[] = formGroup.styles.filter(style => style.isChecked).map(style => style.businessId);
    let createForm: ArtistCreateForm = { name: formGroup.name, description : formGroup.description, styles : [] }
  
    return this.#http.post<CreateArtistResponse>(`${this.#url}Artists/Update`, createForm).pipe(
      switchMap(response => 
        {
        this.updateSelectedArtistId(response.artistId);
        this.#artistsUpdated.next(true)
  
        if (styleIds.length > 0) 
        {
          let rasForm: RelationsArtistStyleForm = { artistId: response.artistId, styleIds: styleIds }
          return this.InsertRAS(rasForm).pipe(
            map(() => response)
          )
        }
        return of(response)
      })
    )
  }

  // Insert Relation ( Artist / Style )
  public InsertRAS( rasForm : RelationsArtistStyleForm ) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/ArtistStyle/Create', rasForm)
  }

  // Delete Artist
  public DeleteArtist( artistId : number ) : Observable<ArtistDeleteResponse> 
  {
    return this.#http.delete<ArtistDeleteResponse>(`${this.#url}Artists/Delete/` + artistId).pipe(
      tap( () => {
        this.#artistsUpdated.next(true)
        this.updateSelectedArtistId(null)
      })
    )
  }

  // ================ STYLES ================================================================
    
  // Get All Styles
  getAllStyles$ = this.#stylesUpdated.pipe(
    switchMap(() => this.#http.get<GetAllStylesResponse>(`${this.#url}Styles/GetAll`)),
    map(response => response.styles),
    catchError(() => of([])),
    shareReplay(1)
  )
  getAllStyles = toSignal(this.getAllStyles$, { initialValue : [] })

  // Create Style
  public CreateStyle( form : StyleCreateForm ) : Observable<CreateStyleResponse> 
  {
    return this.#http.post<CreateStyleResponse>(`${this.#url}Styles/Create`, form).pipe(
      tap(response => {
        this.#stylesUpdated.next(true)
        this.updateCurrentStyleId(response.styleId)
      })
    )
  }

  // Update Style
  public UpdateStyle( form : StyleLight ) : Observable<BaseResponse>
  {
    return this.#http.put<BaseResponse>(`${this.#url}Styles/Update`, form).pipe( 
      tap( () => {
        this.#stylesUpdated.next(true)
        this.updateCurrentStyleId(form.businessId)
      })
    )
  }

  // Delete Style
  public DeleteStyle( styleId : number ) : Observable<BaseResponse> 
  {
    return this.#http.delete<BaseResponse>(`${this.#url}Styles/Delete/` + styleId).pipe(
      tap( () => {
        this.#stylesUpdated.next(true)
        this.updateCurrentStyleId(null)
      })
    )
  }
}