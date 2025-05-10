import { HttpClient } from '@angular/common/http'
import { inject, Injectable } from '@angular/core'
import { environment } from '../../../environments/environment'
import { BehaviorSubject, catchError, combineLatest, distinctUntilChanged, map, merge, Observable, of, shareReplay, startWith, Subject, switchMap, tap, withLatestFrom } from 'rxjs'
import { toSignal } from '@angular/core/rxjs-interop'
import { NotificationService } from '../user-interface/notification.service'
import { StorageService } from '../storage.service'
import { BaseResponse } from '../../interfaces/http/base-response'
import { ArtistCreateForm, StyleCreateForm } from '../../interfaces/http/forms-create'
import { ArtistUpdateForm, StyleUpdateForm } from '../../interfaces/http/forms-update'
import { CreateArtistResponse, CreateStyleResponse } from '../../interfaces/http/responses-create'
import { GetAllArtistsResponse, ArtistFull, StyleFull, ArtistLight, GetAllStylesResponse, GetArtistByIdResponse, GetStyleByIdResponse, GetArtistsByStyleResponse, GetStylesCheckBoxesByArtistResponse, StyleLight, StyleCheckBox } from '../../interfaces/artist'
import { StateService } from '../custom-state/state.service'
import { StorageProperties } from '../../enumerations/storage-properties'
import { StatisticsService } from './statistics.service'

@Injectable({
  providedIn: 'root'
})
export class ArtistService {
  #stateService = inject(StateService)

  #http = inject(HttpClient)
  #storageService = inject(StorageService)
  #notificationService = inject(NotificationService)
  #statisticsService = inject(StatisticsService)

  #url: string = environment.apiBaseUrl + '/api/V1/'

  #styleId$ = new BehaviorSubject<number | undefined>(undefined)

  #refreshArtists$ = new Subject<void>()
  #refreshStyles$ = new Subject<void>()
  #refreshArtist$ = new Subject<void>()
  #refreshStyle$ = new Subject<void>()

  #artists$ = this.#refreshArtists$.pipe(
    startWith([]),
    switchMap(() => this.getAllArtists()),
    shareReplay(1))

  #styles$ = this.#refreshStyles$.pipe(
    startWith([]),
    switchMap(() => this.getAllStyles()),
    shareReplay(1))

  #artistsByStyle$ = combineLatest([this.#styleId$, this.#refreshArtists$.pipe(startWith(undefined))]).pipe(
    switchMap(([styleId]) => styleId ? this.getArtistsByStyle(styleId) : this.#artists$))

  #artist$ = merge(this.#stateService.artistId$.pipe(distinctUntilChanged()), 
  this.#refreshArtist$.pipe(withLatestFrom(this.#stateService.artistId$), map(([_, artistId]) => artistId))).pipe(
    startWith(undefined),
    switchMap(artistId => {
      if (!artistId) return of(undefined)
      return this.getArtistById(artistId)
    })
  )

  #style$ = merge(this.#styleId$.pipe(distinctUntilChanged()), 
  this.#refreshStyle$.pipe(withLatestFrom(this.#styleId$), map(([_, styleId]) => styleId))).pipe(
    startWith(undefined),
    switchMap(styleId => {
      if (!styleId) return of(undefined)
      return this.getStyleById(styleId)
    })
  )

  constructor() {
    let storedStyleId = this.#storageService.getItem(StorageProperties.StateStyleId)
    let storedArtistId = this.#storageService.getItem(StorageProperties.StateArtistId)

    if (storedStyleId != null) { this.setStyleId(storedStyleId as number) }
    if (storedArtistId != null) { this.#stateService.setArtistId(storedArtistId as number) }
  }

  public setStyleId(styleId: number | undefined) {
    this.#storageService.setItem(StorageProperties.StateStyleId, styleId)
    this.#stateService.setArtistId(undefined)
    this.#styleId$.next(styleId)
  }

  public getAllArtists(): Observable<ArtistLight[]> {
    return this.#http.get<GetAllArtistsResponse>(`${this.#url}Artists/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artists),
      catchError(() => of([])))
  }

  public getAllStyles(): Observable<StyleLight[]> {
    return this.#http.get<GetAllStylesResponse>(`${this.#url}Styles/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.styles),
      catchError(() => of([])))
  }

  public getArtistById(artistId: number): Observable<ArtistFull | undefined> {
    return this.#http.get<GetArtistByIdResponse>(`${this.#url}Artists/GetOneDetails/${artistId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artist),
      catchError(() => of(undefined)))
  }

  public getStyleById(styleId: number): Observable<StyleFull | undefined> {
    return this.#http.get<GetStyleByIdResponse>(`${this.#url}Styles/GetOneDetails/${styleId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.style),
      catchError(() => of(undefined)))
  }

  public getArtistsByStyle(styleId: number): Observable<ArtistLight[]> {
    return this.#http.get<GetArtistsByStyleResponse>(`${this.#url}Artists/GetByStyle/${styleId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artists),
      catchError(() => of([])))
  }

  public getStylesCheckBoxesByArtist(artistId: number): Observable<StyleCheckBox[]> {
    return this.#http.get<GetStylesCheckBoxesByArtistResponse>(`${this.#url}Styles/GetCheckBoxesByArtist/${artistId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.styles),
      catchError(() => of([])))
  }

  public createArtist(form: ArtistCreateForm): Observable<CreateArtistResponse> {
    return this.#http.post<CreateArtistResponse>(`${this.#url}Artists/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setArtistId(response.artistId)
          this.#refreshArtists$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', artistId: undefined } as CreateArtistResponse)))
  }

  public createStyle(form: StyleCreateForm): Observable<CreateStyleResponse> {
    return this.#http.post<CreateStyleResponse>(`${this.#url}Styles/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setStyleId(response.styleId)
          this.#refreshStyles$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', styleId: undefined } as CreateStyleResponse)))
  }

  public updateArtist(form: ArtistUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}Artists/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshArtist$.next()
          this.#refreshArtists$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public updateStyle(form: StyleUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}Styles/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshStyle$.next()
          this.#refreshStyles$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteArtist(artistId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}Artists/Delete/${artistId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setArtistId(undefined)
          this.#refreshArtists$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteStyle(styleId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}Styles/Delete/${styleId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setStyleId(undefined)
          this.#refreshStyles$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public artistsFlow = toSignal(
    combineLatest({
      artists: this.#artists$,
      styles: this.#styles$,
      artistsByStyle: this.#artistsByStyle$,
      artist: this.#artist$,
      style: this.#style$
    }))
}