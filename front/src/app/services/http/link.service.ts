import { HttpClient } from '@angular/common/http'
import { inject, Injectable } from '@angular/core'
import { environment } from '../../../environments/environment'
import { BehaviorSubject, catchError, combineLatest, distinctUntilChanged, map, merge, Observable, of, shareReplay, startWith, Subject, switchMap, tap, withLatestFrom } from 'rxjs'
import { BaseResponse } from '../../interfaces/base-response'
import { LinkCategoryCreateForm, LinkCreateForm } from '../../interfaces/forms-create'
import { LinkCategoryUpdateForm, LinkUpdateForm } from '../../interfaces/forms-update'
import { CreateLinkCategoryResponse, CreateLinkResponse } from '../../interfaces/responses-create'
import { NotificationService } from '../notification.service'
import { GetLinkCategoriesCheckBoxesResponse, GetLinkCategoriesResponse, GetLinkCategoryResponse, GetLinkResponse, GetLinksResponse, LinkCategoryCheckBox, LinkCategoryFull, LinkCategoryLight, LinkFull, LinkLight } from '../../interfaces/link'
import { toSignal } from '@angular/core/rxjs-interop'
import { StorageService } from '../storage.service'
import { StorageProperties } from '../../enumerations/storage-properties'
import { StatisticsService } from './statistics.service'

@Injectable({
  providedIn: 'root'
})
export class LinkService {
  #http = inject(HttpClient)
  #storageService = inject(StorageService)
  #notificationService = inject(NotificationService)
  #statisticsService = inject(StatisticsService)

  #url: string = environment.apiBaseUrl + '/api/V1/'

  #linkId$ = new BehaviorSubject<number | undefined>(undefined)
  #linkCategoryId$ = new BehaviorSubject<number | undefined>(undefined)

  #refreshLinks$ = new Subject<void>()
  #refreshLinkCategories$ = new Subject<void>()
  #refreshLink$ = new Subject<void>()
  #refreshLinkCategory$ = new Subject<void>()

  #links$ = this.#refreshLinks$.pipe(
    startWith([]),
    switchMap(() => this.getAllLinks()),
    shareReplay(1))

  #linkCategories$ = this.#refreshLinkCategories$.pipe(
    startWith([]),
    switchMap(() => this.getAllLinkCategories()),
    shareReplay(1))

  #linksByCategory$ = combineLatest([
    this.#linkCategoryId$.pipe(distinctUntilChanged()), this.#refreshLinks$.pipe(startWith(undefined))]).pipe(
      startWith([]),
      switchMap(([linkCategoryId]) => linkCategoryId ? this.getLinksByCategory(linkCategoryId) : this.#links$)
    )

  #link$ = merge(this.#linkId$.pipe(distinctUntilChanged()),
    this.#refreshLink$.pipe(withLatestFrom(this.#linkId$), map(([_, linkId]) => linkId))).pipe(
      startWith(undefined),
      switchMap(linkId => {
        return linkId ? this.getLinkById(linkId) : of(undefined)
      })
    )

  #linkCategory$ = merge(this.#linkCategoryId$.pipe(distinctUntilChanged()),
    this.#refreshLinkCategory$.pipe(withLatestFrom(this.#linkCategoryId$), map(([_, linkCategoryId]) => linkCategoryId))).pipe(
      startWith(undefined),
      switchMap(linkCategoryId => {
        return linkCategoryId ? this.getLinkCategoryById(linkCategoryId) : of(undefined)
      })
    )

  constructor() {
    let storedLinkCategoryId = this.#storageService.getItem(StorageProperties.StateLinkCategoryId)
    let storedLinkId = this.#storageService.getItem(StorageProperties.StateLinkId)

    if (storedLinkCategoryId != null) { this.setLinkCategoryId(storedLinkCategoryId as number) }
    if (storedLinkId != null) { this.setLinkId(storedLinkId as number) }
  }

  public setLinkId(linkId: number | undefined): void {
    this.#linkId$.next(linkId)
    this.#storageService.setItem(StorageProperties.StateLinkId, linkId)
  }

  public setLinkCategoryId(linkCategoryId: number | undefined): void {
    this.setLinkId(undefined)
    this.#linkCategoryId$.next(linkCategoryId)
    this.#storageService.setItem(StorageProperties.StateLinkCategoryId, linkCategoryId)
  }

  public getAllLinks(): Observable<LinkLight[]> {
    return this.#http.get<GetLinksResponse>(`${this.#url}Links/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.links),
      catchError(() => of([])))
  }

  public getAllLinkCategories(): Observable<LinkCategoryLight[]> {
    return this.#http.get<GetLinkCategoriesResponse>(`${this.#url}LinkCategories/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.linkCategories),
      catchError(() => of([])))
  }

  public getLinkById(linkId: number): Observable<LinkFull | undefined> {
    return this.#http.get<GetLinkResponse>(`${this.#url}Links/GetOneDetails/${linkId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.link),
      catchError(() => of(undefined)))
  }

  public getLinkCategoryById(linkCategoryId: number): Observable<LinkCategoryFull | undefined> {
    return this.#http.get<GetLinkCategoryResponse>(`${this.#url}LinkCategories/GetOneDetails/${linkCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.linkCategory),
      catchError(() => of(undefined)))
  }

  public getLinksByCategory(linkCategoryId: number): Observable<LinkLight[]> {
    return this.#http.get<GetLinksResponse>(`${this.#url}Links/GetByCategory/${linkCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.links),
      catchError(() => of([])))
  }

  public getLinkCategoriesCheckBoxes(linkId: number): Observable<LinkCategoryCheckBox[]> {
    return this.#http.get<GetLinkCategoriesCheckBoxesResponse>(`${this.#url}LinkCategories/GetCheckBoxesByLink/${linkId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.linkCategories),
      catchError(() => of([])))
  }

  public createLink(form: LinkCreateForm): Observable<CreateLinkResponse> {
    return this.#http.post<CreateLinkResponse>(`${this.#url}Links/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setLinkId(response.linkId)
          this.#refreshLinks$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', linkId: undefined } as CreateLinkResponse)))
  }

  public createLinkCategory(form: LinkCategoryCreateForm): Observable<CreateLinkCategoryResponse> {
    return this.#http.post<CreateLinkCategoryResponse>(`${this.#url}LinkCategories/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setLinkCategoryId(response.linkCategoryId)
          this.#refreshLinkCategories$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', linkCategoryId: undefined } as CreateLinkCategoryResponse)))
  }

  public updateLink(form: LinkUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}Links/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshLink$.next()
          this.#refreshLinks$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public updateLinkCategory(form: LinkCategoryUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}LinkCategories/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshLinkCategory$.next()
          this.#refreshLinkCategories$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteLink(linkId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}Links/Delete/${linkId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setLinkId(undefined)
          this.#refreshLinks$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public deleteLinkCategory(linkCategoryId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}LinkCategories/Delete/${linkCategoryId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.setLinkCategoryId(undefined)
          this.#refreshLinkCategories$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public linksFlow = toSignal(combineLatest({
    linksByCategory: this.#linksByCategory$,
    link: this.#link$,
    linkCategories: this.#linkCategories$,
    linkCategory: this.#linkCategory$
  }))
}