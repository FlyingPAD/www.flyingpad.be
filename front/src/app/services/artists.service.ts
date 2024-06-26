import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { BehaviorSubject, Observable, catchError, combineLatest, debounceTime, map, of, shareReplay, startWith, switchMap, tap } from 'rxjs';
import { FormControl } from '@angular/forms';
import { ArtistCreateForm, ArtistCreateFormGroup, ArtistDeleteResponse, ArtistDetails, ArtistsCountResponse, ArtistsCreateResponse, ArtistsGetPageResponse, GetArtistByIdResponse } from '../models/artist';
import { toSignal } from '@angular/core/rxjs-interop';
import { GetOneStyleDetailsResponse, StyleCreateForm, StyleDetails, StyleUpdateForm, StylesCreateResponse, StylesDeleteResponse, GetAllStylesResponse, StylesUpdateResponse, StyleCheck } from '../models/style';
import { GetMoodsByArtistResponse } from '../models/mood';
import { CheckRelationsArtistStyleByStyleResponse, CreateRelationsArtistStyleResponse, RelationsArtistStyleForm } from '../models/relations';

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
    map(response => response.stylesList),
    catchError(() => of([])),
    shareReplay(1)
  )

  styleDetails$ = this.selectedStyleId$.pipe(
    switchMap(styleId => 
    {
      if (styleId === null) return of(null);
      return this.#http.get<GetOneStyleDetailsResponse>(`${this.#url}Styles/GetOneDetails/${styleId}`).pipe(
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
    startWith({ style: new StyleDetails(), relations: null })
  )
  styleFlow = toSignal(this.styleFlow$, { initialValue: { style: new StyleDetails(), relations: null } });

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
  artistFlow = toSignal(this.artistFlow$, { initialValue: { artist : new ArtistDetails(), moods : [] } })

  public GetOneDetails( artistId : number )
  {
    return this.#http.get<GetArtistByIdResponse>(`${this.#url}Artists/GetOneDetails/${artistId}`).pipe(
      map(response => response.artist))
  }

  public GetMoodsByArtist( artistId : number )
  {
    return this.#http.get<GetMoodsByArtistResponse>(this.#url + 'Moods/GetByArtist/' + artistId).pipe(
      map(response => response.moods))
  }

  // Create Artist
  public CreateArtist(formGroup: ArtistCreateFormGroup): Observable<ArtistsCreateResponse> {
    let styleIds: number[] = formGroup.styles.filter(style => style.isChecked).map(style => style.businessId);
    let createForm: ArtistCreateForm = { name: formGroup.name };
  
    return this.#http.post<ArtistsCreateResponse>(`${this.#url}Artists/Create`, createForm).pipe(
      switchMap(response => {
        this.updateSelectedArtistId(response.artist.businessId);
        this.#artistsUpdated.next(true);  // Déplacer ici pour garantir l'exécution
  
        if (styleIds.length > 0) {
          let rasForm: RelationsArtistStyleForm = { artistId: response.artist.businessId, styleIds: styleIds };
          return this.InsertRAS(rasForm).pipe(
            map(() => response)
          );
        }
  
        return of(response);
      })
    );
  }

  // Update Artist
  public UpdateArtist( formGroup : ArtistCreateFormGroup ) : Observable<ArtistsCreateResponse> 
  {
    let styleIds: number[] = formGroup.styles.filter(style => style.isChecked).map(style => style.businessId);
    let createForm: ArtistCreateForm = { name: formGroup.name };
  
    return this.#http.post<ArtistsCreateResponse>(`${this.#url}Artists/Update`, createForm).pipe(
      switchMap(response => 
        {
        this.updateSelectedArtistId(response.artist.businessId);
        this.#artistsUpdated.next(true)
  
        if (styleIds.length > 0) 
        {
          let rasForm: RelationsArtistStyleForm = { artistId: response.artist.businessId, styleIds: styleIds }
          return this.InsertRAS(rasForm).pipe(
            map(() => response)
          )
        }
        return of(response)
      })
    )
  }

  // Insert Relation ( Artist / Style )
  public InsertRAS( rasForm : RelationsArtistStyleForm ) : Observable<CreateRelationsArtistStyleResponse>
  {
    return this.#http.post<CreateRelationsArtistStyleResponse>(this.#url + 'Relations/ArtistStyle/Create', rasForm)
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
    map(response => response.stylesList),
    catchError(() => of([])),
    shareReplay(1)
  )
  getAllStyles = toSignal(this.getAllStyles$, { initialValue : [] as StyleCheck[] })

  // Create Style
  public CreateStyle( form : StyleCreateForm ) : Observable<StylesCreateResponse> 
  {
    return this.#http.post<StylesCreateResponse>(`${this.#url}Styles/Create`, form).pipe(
      tap(response => {
        this.#stylesUpdated.next(true)
        this.updateCurrentStyleId(response.style.businessId)
      })
    )
  }

  // Update Style
  public UpdateStyle( form : StyleUpdateForm ) : Observable<StylesUpdateResponse>
  {
    return this.#http.put<StylesUpdateResponse>(`${this.#url}Styles/Update`, form).pipe( 
      tap( () => {
        this.#stylesUpdated.next(true)
        this.updateCurrentStyleId(form.businessId)
      })
    )
  }

  // Delete Style
  public DeleteStyle( styleId : number ) : Observable<StylesDeleteResponse> 
  {
    return this.#http.delete<StylesDeleteResponse>(`${this.#url}Styles/Delete/` + styleId).pipe(
      tap( () => {
        this.#stylesUpdated.next(true)
        this.updateCurrentStyleId(null)
      })
    )
  }
}