import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { NotificationService } from '../user-interface/notification.service';
import { combineLatest, map, Observable, shareReplay, startWith, Subject, switchMap, tap, of, merge, distinctUntilChanged, catchError, withLatestFrom } from 'rxjs';
import { ModelCreateForm } from '../../interfaces/http/forms-create';
import { GetAllModelsResponse, GetModelResponse, ModelFull, ModelLight } from '../../interfaces/model';
import { BaseResponse } from '../../interfaces/http/base-response';
import { ModelUpdateForm } from '../../interfaces/http/forms-update';
import { toSignal } from '@angular/core/rxjs-interop';
import { StateService } from '../custom-state/state.service';
import { StorageService } from '../storage.service';
import { StorageProperties } from '../../enumerations/storage-properties';
import { FranchiseLight, GetFranchisesByModelResponse } from '../../interfaces/franchise';
import { StatisticsService } from './statistics.service';
import { CreateModelResponse } from '../../interfaces/http/responses-create';

@Injectable({
  providedIn: 'root'
})
export class ModelService {
  #stateService = inject(StateService)

  #http = inject(HttpClient)
  #storageService = inject(StorageService)
  #notificationService = inject(NotificationService)
  #statisticsService = inject(StatisticsService)

  #url: string = environment.apiBaseUrl + '/api/V1/'

  #refreshModels$ = new Subject<void>()
  #refreshModel$ = new Subject<void>()

  #models$ = this.#refreshModels$.pipe(
    startWith([]),
    switchMap(() => this.getAllModels()),
    shareReplay(1)
  )

  #model$ = merge(this.#stateService.modelId$.pipe(distinctUntilChanged()), 
  this.#refreshModel$.pipe(withLatestFrom(this.#stateService.modelId$), map(([_, modelId]) => modelId))).pipe(
    startWith(undefined),
    switchMap((modelId) => {
      if (!modelId) return of(undefined)
      return combineLatest([this.getModelById(modelId), this.getFranchisesByModel(modelId)]).pipe(
        map(([model, relatedFranchises]) => ({ ...model, relatedFranchises } as ModelFull)))
    }))

  constructor() {
    let storedModelId = this.#storageService.getItem(StorageProperties.StateModelId)
    if (storedModelId != null) { this.#stateService.setModelId(storedModelId as number) }
  }

  public getAllModels(): Observable<ModelLight[]> {
    return this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.models),
      catchError(() => of([])))      
  }

  public getModelById(modelId: number): Observable<ModelFull | undefined> {
    return this.#http.get<GetModelResponse>(`${this.#url}Models/GetOneDetails/${modelId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.model),
      catchError(() => of(undefined)))
  }

  public getFranchisesByModel(modelId: number): Observable<FranchiseLight[]> {
    return this.#http.get<GetFranchisesByModelResponse>(`${this.#url}Franchises/GetByModel/${modelId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchisesByModel),
      catchError(() => of([])))   
  }

  public createModel(form: ModelCreateForm): Observable<CreateModelResponse> {
    return this.#http.post<CreateModelResponse>(`${this.#url}Models/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setModelId(response.modelId)
          this.#refreshModels$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', modelId: undefined } as CreateModelResponse)))
  }

  public updateModel(form: ModelUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Models/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshModel$.next()
          this.#refreshModels$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteModel(modelId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Models/Delete/${modelId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setModelId(undefined)
          this.#refreshModels$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public modelsFlow = toSignal(combineLatest({
    models: this.#models$,
    model: this.#model$
  }))
}