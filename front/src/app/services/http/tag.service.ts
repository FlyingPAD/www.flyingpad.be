import { HttpClient } from '@angular/common/http'
import { inject, Injectable } from '@angular/core'
import { environment } from '../../../environments/environment'
import { catchError, combineLatest, distinctUntilChanged, map, merge, Observable, of, shareReplay, startWith, Subject, switchMap, tap, withLatestFrom } from 'rxjs'
import { toSignal } from '@angular/core/rxjs-interop'
import { NotificationService } from '../user-interface/notification.service'
import { StorageService } from '../storage.service'
import { BaseResponse } from '../../interfaces/http/base-response'
import { TagCreateForm, TagCategoryCreateForm } from '../../interfaces/http/forms-create'
import { TagUpdateForm, TagCategoryUpdateForm } from '../../interfaces/http/forms-update'
import { CreateTagResponse, CreateTagCategoryResponse } from '../../interfaces/http/responses-create'
import { GetAllTagCategoriesResponse, GetAllTagsResponse, GetTagByIdResponse, GetTagCategoryByIdResponse, GetTagsByCategoryResponse, TagCategoryFull, TagCategoryLight, TagFull, TagLight, TagList, TagsGetFullListResponse } from '../../interfaces/tag'
import { StateService } from '../custom-state/state.service'
import { StorageProperties } from '../../enumerations/storage-properties'
import { StatisticsService } from './statistics.service'

@Injectable({
  providedIn: 'root'
})
export class TagService {
  #stateService = inject(StateService)

  #http = inject(HttpClient)
  #storageService = inject(StorageService)
  #notificationService = inject(NotificationService)
  #statisticsService = inject(StatisticsService)

  #url: string = environment.apiBaseUrl + '/api/V1/'

  #refreshTags$ = new Subject<void>()
  #refreshTagCategories$ = new Subject<void>()
  #refreshTag$ = new Subject<void>()
  #refreshTagCategory$ = new Subject<void>()

  #tagsList$ = this.#refreshTags$.pipe(
    startWith([]),
    switchMap(() => this.getTagsList()),
    shareReplay(1)
  )

  #tags$ = this.#refreshTags$.pipe(
    startWith([]),
    switchMap(() => this.getAllTags()),
    shareReplay(1)
  )

  #tagCategories$ = this.#refreshTagCategories$.pipe(
    startWith([]),
    switchMap(() => this.getAllTagCategories()),
    shareReplay(1)
  )

  #tagsByCategory$ = combineLatest([this.#stateService.tagCategoryId$.pipe(distinctUntilChanged()), this.#refreshTags$.pipe(startWith(undefined))]).pipe(
    startWith([]),
    switchMap(([tagCategoryId]) => tagCategoryId ? this.getTagsByTagCategory(tagCategoryId) : this.#tags$)
  )

  #tag$ = merge(
    this.#stateService.tagId$.pipe(distinctUntilChanged()),
    this.#refreshTag$.pipe(withLatestFrom(this.#stateService.tagId$), map(([_, tagId]) => tagId))).pipe(
    startWith(undefined),
    switchMap(tagId => {
      if (!tagId) return of(undefined)
      return this.getTagById(tagId)
    })
  )

  #tagCategory$ = merge(
    this.#stateService.tagCategoryId$.pipe(distinctUntilChanged()),
    this.#refreshTagCategory$.pipe(withLatestFrom(this.#stateService.tagCategoryId$), map(([_, tagCategoryId]) => tagCategoryId))).pipe(
    startWith(undefined),
    switchMap(tagCategoryId => {
      if (!tagCategoryId) return of(undefined)
      return this.getTagCategoryById(tagCategoryId)
    })
  )

  constructor() {
    let storedTagCategoryId = this.#storageService.getItem(StorageProperties.StateTagCategoryId)
    let storedTagId = this.#storageService.getItem(StorageProperties.StateTagId)

    if (storedTagCategoryId != null) { this.setTagCategoryId(storedTagCategoryId as number) }
    if (storedTagId != null) { this.#stateService.setTagId(storedTagId as number) }
  }

  public setTagCategoryId(tagCategoryId: number | undefined) {
    this.#stateService.setTagId(undefined)
    this.#stateService.setTagCategoryId(tagCategoryId)
    this.#storageService.setItem(StorageProperties.StateTagCategoryId, tagCategoryId)
  }

  public getTagsList(): Observable<TagList[]> {
    return this.#http.get<TagsGetFullListResponse>(`${this.#url}Tags/GetTagsList`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.categoriesWithTags),
      catchError(() => of([])))
  }

  public getAllTags(): Observable<TagLight[]> {
    return this.#http.get<GetAllTagsResponse>(`${this.#url}Tags/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tags),
      catchError(() => of([])))
  }

  public getAllTagCategories(): Observable<TagCategoryLight[]> {
    return this.#http.get<GetAllTagCategoriesResponse>(`${this.#url}TagCategories/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tagCategories),
      catchError(() => of([])))
  }

  public getTagById(tagId: number): Observable<TagFull | undefined> {
    return this.#http.get<GetTagByIdResponse>(`${this.#url}Tags/GetOneDetails/${tagId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tag),
      catchError(() => of(undefined)))
  }

  public getTagCategoryById(tagCategoryId: number): Observable<TagCategoryFull | undefined> {
    return this.#http.get<GetTagCategoryByIdResponse>(`${this.#url}TagCategories/GetOneDetails/${tagCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tagCategory),
      catchError(() => of(undefined)))
  }

  public getTagsByTagCategory(tagCategoryId: number): Observable<TagLight[]> {
    return this.#http.get<GetTagsByCategoryResponse>(`${this.#url}Tags/GetByCategory/${tagCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tags),
      catchError(() => of([])))
  }

  public createTag(form: TagCreateForm): Observable<CreateTagResponse> {
    return this.#http.post<CreateTagResponse>(`${this.#url}Tags/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setTagId(response.tagId)
          this.#refreshTags$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', tagId: undefined } as CreateTagResponse)))
  }

  public createTagCategory(form: TagCategoryCreateForm): Observable<CreateTagCategoryResponse> {
    return this.#http.post<CreateTagCategoryResponse>(`${this.#url}TagCategories/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setTagCategoryId(response.tagCategoryId)
          this.#refreshTagCategories$.next()
          this.#refreshTags$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', tagCategoryId: undefined } as CreateTagCategoryResponse)))
  }

  public updateTag(form: TagUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}Tags/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshTag$.next()
          this.#refreshTags$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public updateTagCategory(form: TagCategoryUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}TagCategories/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshTagCategory$.next()
          this.#refreshTagCategories$.next()
          this.#refreshTags$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteTag(tagId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}Tags/Delete/${tagId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setTagId(undefined)
          this.#refreshTags$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteTagCategory(tagCategoryId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}TagCategories/Delete/${tagCategoryId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setTagCategoryId(undefined)
          this.#refreshTagCategories$.next()
          this.#refreshTags$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public tagsFlow = toSignal(
    combineLatest({
      tagsList: this.#tagsList$,
      tagCategories: this.#tagCategories$,
      tagsByCategory: this.#tagsByCategory$,
      tag: this.#tag$,
      tagCategory: this.#tagCategory$,
    })
  )
}