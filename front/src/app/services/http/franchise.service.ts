import { HttpClient } from '@angular/common/http'
import { inject, Injectable } from '@angular/core'
import { environment } from '../../../environments/environment'
import { BehaviorSubject, catchError, combineLatest, distinctUntilChanged, map, merge, Observable, of, shareReplay, startWith, Subject, switchMap, tap } from 'rxjs'
import { toSignal } from '@angular/core/rxjs-interop'
import { NotificationService } from '../user-interface/notification.service'
import { StorageService } from '../storage.service'
import { BaseResponse } from '../../interfaces/http/base-response'
import { FranchiseCreateForm, MediumCreateForm } from '../../interfaces/http/forms-create'
import { FranchiseUpdateForm, MediumUpdateForm } from '../../interfaces/http/forms-update'
import { CreateFranchiseResponse, CreateMediumResponse } from '../../interfaces/http/responses-create'
import { FranchiseFull, FranchiseLight, GetAllFranchisesResponse, GetAllMediaResponse, GetFranchiseByIdResponse, GetFranchisesByMediumResponse, GetFranchisesCheckBoxesByModelResponse, GetMediaCheckBoxesByFranchiseResponse, GetMediaListResponse, GetMediumByIdResponse, MediumFull, MediumLight, MediaList, FranchiseCheckBox, MediumCheckBox } from '../../interfaces/franchise'
import { StateService } from '../custom-state/state.service'
import { StorageProperties } from '../../enumerations/storage-properties'
import { GetModelsByFranchiseResponse, ModelLight } from '../../interfaces/model'
import { StatisticsService } from './statistics.service'

@Injectable({
  providedIn: 'root'
})

export class FranchiseService {
  #stateService = inject(StateService)

  #http = inject(HttpClient)
  #storageService = inject(StorageService)
  #notificationService = inject(NotificationService)
  #statisticsService = inject(StatisticsService)

  #url: string = environment.apiBaseUrl + '/api/V1/'

  #mediumId$ = new BehaviorSubject<number | undefined>(undefined)

  #refreshFranchises$ = new Subject<void>()
  #refreshMedia$ = new Subject<void>()
  #refreshFranchise$ = new Subject<void>()
  #refreshMedium$ = new Subject<void>()

  #mediaList$ = this.#refreshFranchises$.pipe(
    startWith([]),
    switchMap(() => this.getMediaList()),
    shareReplay(1))

  #franchises$ = this.#refreshFranchises$.pipe(
    startWith([]),
    switchMap(() => this.getAllFranchises()),
    shareReplay(1))

  #media$ = this.#refreshMedia$.pipe(
    startWith([]),
    switchMap(() => this.getAllMedia()),
    shareReplay(1))

  #franchisesByMedium$ = combineLatest([this.#mediumId$, this.#refreshFranchises$.pipe(startWith(undefined))]).pipe(
    startWith([]),
    switchMap(([mediumId]) => mediumId ? this.getFranchisesByMedium(mediumId) : this.#franchises$))

  #franchise$ = merge(this.#stateService.franchiseId$.pipe(distinctUntilChanged()), this.#refreshFranchise$).pipe(
    startWith(undefined),
    switchMap((franchiseId) => {
      if (!franchiseId) return of(undefined)
      return combineLatest([this.getFranchiseById(franchiseId), this.getModelsByFranchise(franchiseId)]).pipe(
        map(([franchise, relatedModels]) => ({ ...franchise, relatedModels }  as FranchiseFull)))
    }))

  #medium$ = merge(this.#mediumId$.pipe(distinctUntilChanged()), this.#refreshMedium$).pipe(
    startWith(undefined),
    switchMap(mediumId => {
      if (!mediumId) return of(undefined)
      return this.getMediumById(mediumId)
    })
  )

  constructor() {
    let storedMediumId = this.#storageService.getItem(StorageProperties.StateMediumId)
    let storedFranchiseId = this.#storageService.getItem(StorageProperties.StateFranchiseId)

    if (storedMediumId != null) { this.setMediumId(storedMediumId as number) }
    if (storedFranchiseId != null) { this.#stateService.setFranchiseId(storedFranchiseId as number) }
  }

  public setMediumId(mediumId: number | undefined) {
    this.#stateService.setFranchiseId(undefined)
    this.#mediumId$.next(mediumId)
    this.#storageService.setItem(StorageProperties.StateMediumId, mediumId)
  }

  public getMediaList(): Observable<MediaList[]> {
    return this.#http.get<GetMediaListResponse>(`${this.#url}Franchises/GetFranchisesList`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.media),
      catchError(() => of([])))
  }

  public getAllFranchises(): Observable<FranchiseLight[]> {
    return this.#http.get<GetAllFranchisesResponse>(`${this.#url}Franchises/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchises),
      catchError(() => of([])))
  }

  public getAllMedia(): Observable<MediumLight[]> {
    return this.#http.get<GetAllMediaResponse>(`${this.#url}Media/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.media),
      catchError(() => of([])))
  }

  public getFranchiseById(franchiseId: number): Observable<FranchiseFull | undefined> {
    return this.#http.get<GetFranchiseByIdResponse>(`${this.#url}Franchises/GetOneDetails/${franchiseId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchise),
      catchError(() => of(undefined)))
  }

  public getMediumById(mediumId: number): Observable<MediumFull | undefined> {
    return this.#http.get<GetMediumByIdResponse>(`${this.#url}Media/GetOneDetails/${mediumId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.medium),
      catchError(() => of(undefined)))
  }

  public getFranchisesByMedium(mediumId: number): Observable<FranchiseLight[]> {
    return this.#http.get<GetFranchisesByMediumResponse>(`${this.#url}Franchises/GetByMedium/${mediumId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchises),
      catchError(() => of([])))
  }

  public getModelsByFranchise(franchiseId: number): Observable<ModelLight[]> {
    return this.#http.get<GetModelsByFranchiseResponse>(`${this.#url}Models/GetByFranchise/${franchiseId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.modelsByFranchise),
      catchError(() => of([])))
  }

  public getFranchisesCheckBoxesByModel(modelId: number): Observable<FranchiseCheckBox[]> {
    return this.#http.get<GetFranchisesCheckBoxesByModelResponse>(`${this.#url}Franchises/GetCheckBoxesByModel/${modelId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchises),
      catchError(() => of([])))
  }

  public getMediaCheckBoxesByFranchise(franchiseId: number): Observable<MediumCheckBox[]> {
    return this.#http.get<GetMediaCheckBoxesByFranchiseResponse>(`${this.#url}Media/GetCheckBoxesByFranchise/${franchiseId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.media),
      catchError(() => of([])))
  }

  public createFranchise(form: FranchiseCreateForm): Observable<CreateFranchiseResponse> {
    return this.#http.post<CreateFranchiseResponse>(`${this.#url}Franchises/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setFranchiseId(response.franchiseId)
          this.#refreshFranchises$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', franchiseId: undefined } as CreateFranchiseResponse)))
  }

  public createMedium(form: MediumCreateForm): Observable<CreateMediumResponse> {
    return this.#http.post<CreateMediumResponse>(`${this.#url}Media/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setMediumId(response.mediumId)
          this.#refreshMedia$.next()
          this.#refreshFranchises$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', mediumId: undefined } as CreateMediumResponse)))
  }

  public updateFranchise(form: FranchiseUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}Franchises/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshFranchise$.next()
          this.#refreshFranchises$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public updateMedium(form: MediumUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}Media/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshMedium$.next()
          this.#refreshMedia$.next()
          this.#refreshFranchises$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteFranchise(franchiseId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}Franchises/Delete/${franchiseId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setFranchiseId(undefined)
          this.#refreshFranchises$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteMedium(mediumId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}Media/Delete/${mediumId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setMediumId(undefined)
          this.#refreshMedia$.next()
          this.#refreshFranchises$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public franchisesFlow = toSignal(
    combineLatest({
      mediaList: this.#mediaList$,
      franchises: this.#franchises$,
      media: this.#media$,
      franchisesByMedium: this.#franchisesByMedium$,
      franchise: this.#franchise$,
      medium: this.#medium$
    }))
}