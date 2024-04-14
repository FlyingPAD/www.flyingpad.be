import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { BehaviorSubject, Observable, catchError, combineLatest, debounceTime, map, of, shareReplay, startWith, switchMap, tap } from 'rxjs';
import { FormControl } from '@angular/forms';
import { ArtistCreateForm, ArtistDetails, ArtistsCreateResponse, ArtistsGetPageResponse, GetOneArtistDetailsResponse } from '../models/artist';
import { toSignal } from '@angular/core/rxjs-interop';
import { GetOneStyleDetailsResponse, StyleCreateForm, StyleDetails, StyleUpdateForm, StylesCreateResponse, StylesDeleteResponse, StylesGetAllResponse, StylesUpdateResponse } from '../models/style';
import { GetMoodsByArtistResponse } from '../models/mood';
import { CheckRelationsArtistStyleByStyleResponse } from '../models/relations';

@Injectable({
  providedIn: 'root'
})
export class ArtistsStateService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  nameSearchField = new FormControl('')

  #selectedStyleId = new BehaviorSubject<number | null>(null)
  selectedStyleId$ = this.#selectedStyleId.asObservable()
  updateCurrentStyleId( styleId : number | null ) { this.#selectedStyleId.next( styleId ) }

  #startId = new BehaviorSubject<number | null>(null)
  startId$ = this.#startId.asObservable()
  updateStartId( startId : number | null ) { this.#startId.next( startId ) }

  #stylesUpdated = new BehaviorSubject<boolean>(true)

  styles$ = this.#stylesUpdated.pipe(
    switchMap(() => this.#http.get<StylesGetAllResponse>(`${this.#url}Styles/GetAll`)),
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

  styleFlow$ = combineLatest([this.styleDetails$, this.relationsByStyle$]).pipe(
    map(([style, relations]) => ({ style, relations })),
    catchError(() => of({ style: null, relations: null })),
    startWith({ style: new StyleDetails(), relations: null })
  )
  styleFlow = toSignal(this.styleFlow$, { initialValue: { style: new StyleDetails(), relations: null } });

  artistsFlow$ = combineLatest([
    this.selectedStyleId$,
    this.nameSearchField.valueChanges.pipe(startWith('')),
    this.startId$.pipe(startWith(null)),
    this.styles$.pipe(startWith([]))
  ]).pipe(
    debounceTime(100),
    switchMap(([styleId, searchTerm, startId, styles]) => {
      let params = new HttpParams()
        .set('styleId', styleId?.toString() ?? '')
        .set('startId', startId?.toString() ?? '')
        .set('abc', searchTerm || '')
        .set('pageSize', '20')

      return this.#http.get<ArtistsGetPageResponse>(`${this.#url}Artists/GetPage`, { params })
        .pipe(
          map(response => ({
            ...response,
            selectedStyleId: styleId,
            styles
          }))
        )
    }),
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
      selectedStyleId: null
    })),
    shareReplay(1)
  )  
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
      selectedStyleId: null
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
    return this.#http.get<GetOneArtistDetailsResponse>(`${this.#url}Artists/GetOneDetails/${artistId}`).pipe(
      map(response => response.artist))
  }

  public GetMoodsByArtist( artistId : number )
  {
    return this.#http.get<GetMoodsByArtistResponse>(this.#url + 'Moods/GetByArtist/' + artistId).pipe(
      map(response => response.moods))
  }

  // Create Artist
  public CreateArtist( form : ArtistCreateForm ) : Observable<ArtistsCreateResponse> 
  {
    return this.#http.post<ArtistsCreateResponse>(`${this.#url}Artists/Create`, form)
  }

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

}