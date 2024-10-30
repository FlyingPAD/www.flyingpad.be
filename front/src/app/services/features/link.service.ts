import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from '../../../environments/environment';
import { BehaviorSubject, combineLatest, map, Observable, of, startWith, switchMap, tap } from 'rxjs';
import { GetLinksResponse, GetLinkCategoriesResponse, GetLinkCategoryResponse, GetLinkResponse, LinkCategoryFull, LinkFull, LinkLight } from '../../interfaces/link';
import { BaseResponse } from '../../interfaces/base-response';
import { LinkCategoryCreateForm, LinkCreateForm } from '../../interfaces/forms-create';
import { LinkCategoryUpdateForm, LinkUpdateForm } from '../../interfaces/forms-update';
import { CreateLinkCategoryResponse, CreateLinkResponse } from '../../interfaces/responses-create';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class LinkService {
  #http = inject(HttpClient)
  #toastr = inject(ToastrService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  #linkId = new BehaviorSubject<number | null>(null)
  public updateLinkId(linkId: number | null) { this.#linkId.next(linkId) }

  #linkCategoryId = new BehaviorSubject<number | null>(null)
  public updateLinkCategoryId(linkCategoryId: number | null) { this.#linkCategoryId.next(linkCategoryId) }

  #refreshLinkCategories = new BehaviorSubject<boolean>(true)
  public refreshLinkCategories() { this.#refreshLinkCategories.next(true) }

  #refreshLinks = new BehaviorSubject<boolean>(true)
  public refreshLinks() { this.#refreshLinks.next(true) }

  links$ = this.#refreshLinks.pipe(
    switchMap(() => this.#http.get<GetLinksResponse>(`${this.#url}Links/GetAll`)),
    tap(response => {
      // if (response.success) this.#toastr.success(response.message)
      // else this.#toastr.error(response.message)
    }),
    map(response => response.links))

  linkCategories$ = this.#refreshLinkCategories.pipe(
    switchMap(() => this.#http.get<GetLinkCategoriesResponse>(`${this.#url}LinkCategories/GetAll`)),
    tap(response => {
      // if (response.success) this.#toastr.success(response.message)
      // else this.#toastr.error(response.message)
    }),
    map(response => response.linkCategories))

  link$ = this.#linkId.pipe(
    switchMap(linkId => linkId ? this.getLinkById(linkId) : of(undefined)), startWith(undefined))

  linkCategory$ = this.#linkCategoryId.pipe(
    switchMap(linkCategoryId => linkCategoryId ? this.getLinkCategoryById(linkCategoryId) : of(undefined)), startWith(undefined))

  currentLinks$ = combineLatest([this.#linkCategoryId, this.#refreshLinks]).pipe(
    switchMap(([linkCategoryId]) => {
      if (linkCategoryId != null) {
        return this.getLinksByCategory(linkCategoryId)
      } else {
        return this.links$
      }
    }),
    startWith([])
  )

  linkFlow$ = combineLatest([this.linkCategories$, this.currentLinks$, this.linkCategory$, this.link$]).pipe(
    map(([linkCategories, links, linkCategory, link]) => ({ linkCategories, links, linkCategory, link }))
  )
  linkFlow = toSignal(this.linkFlow$)

  // Retrieve.
  public getLinkById(linkId: number): Observable<LinkFull> {
    return this.#http.get<GetLinkResponse>(`${this.#url}Links/GetOneDetails/${linkId}`).pipe(
      tap(response => {
        // if (response.success) this.#toastr.success(response.message)
        // else this.#toastr.error(response.message)
      }),
      map(response => response.link))
  }
  public getLinkCategoryById(linkCategoryId: number): Observable<LinkCategoryFull> {
    return this.#http.get<GetLinkCategoryResponse>(`${this.#url}LinkCategories/GetOneDetails/${linkCategoryId}`).pipe(
      tap(response => {
        // if (response.success) this.#toastr.success(response.message)
        // else this.#toastr.error(response.message)
      }),
      map(response => response.linkCategory))
  }
  public getLinksByCategory(linkCategoryId: number): Observable<LinkLight[]> {
    return this.#http.get<GetLinksResponse>(`${this.#url}Links/GetByCategory/${linkCategoryId}`).pipe(
      tap(response => {
        // if (response.success) this.#toastr.success(response.message)
        // else this.#toastr.error(response.message)
      }),
      map(response => response.links))
  }

  // Create.
  public CreateLinkCategory(form: LinkCategoryCreateForm) {
    return this.#http.post<CreateLinkCategoryResponse>(`${this.#url}LinkCategories/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkCategoryId(response.linkCategoryId)
          this.refreshLinkCategories()
          // this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      })
    )
  }
  public CreateLink(form: LinkCreateForm): Observable<CreateLinkResponse> {
    return this.#http.post<CreateLinkResponse>(`${this.#url}Links/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkId(response.linkId)
          this.refreshLinks()
          this.updateLinkCategoryId(form.linkCategoryIds[0])
          // this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      })
    )
  }

  // Update.
  public UpdateLinkCategory(form: LinkCategoryUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}LinkCategories/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkCategoryId(form.linkCategoryId)
          this.refreshLinkCategories()
          // this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateLink(form: LinkUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Links/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkId(form.linkId)
          this.refreshLinks()
          this.updateLinkCategoryId(form.linkCategoryIds[0])
          this.refreshLinkCategories()
          // this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }

  // Delete.
  public DeleteLinkCategory(linkCategoryId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}LinkCategories/Delete/${linkCategoryId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkCategoryId(null)
          this.refreshLinkCategories()
          // this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteLink(linkId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Links/Delete/${linkId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkId(null)
          this.refreshLinks()
          // this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
}