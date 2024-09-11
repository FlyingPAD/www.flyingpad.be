import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { BehaviorSubject, combineLatest, of } from 'rxjs';
import { map, switchMap, tap } from 'rxjs/operators';
import { GetLinkCategoriesResponse, GetLinkCategoryResponse, GetLinkResponse, GetLinksResponse } from '../models/link';
import { toSignal } from '@angular/core/rxjs-interop';
import { BaseResponse } from '../models/base-response';
import { LinkCreateForm } from '../models/forms-create';
import { LinkUpdateForm } from '../models/forms-update';
import { CreateLinkResponse } from '../models/responses-create';

@Injectable({
  providedIn: 'root'
})
export class LinksEditionService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedLinkId = new BehaviorSubject<number | null>(null)
  selectedLinkId$ = this.#selectedLinkId.asObservable()
  updateSelectedLink(linkId : number | null) {
    this.#selectedLinkId.next(linkId)
  }
  #selectedCategoryId = new BehaviorSubject<number | null>(null)
  selectedCategoryId$ = this.#selectedCategoryId.asObservable()
  updateSelectedCategory(categoryId : number | null) {
    this.#selectedCategoryId.next(categoryId)
  }

  links$ = this.#http.get<GetLinksResponse>(this.#url + 'Links/GetAll').pipe(
    map(x => x.links)
  )
  linkCategories$ = this.#http.get<GetLinkCategoriesResponse>(this.#url + 'LinkCategories/GetAll').pipe(
    map(x => x.linkCategories)
  )

  getLink( linkId : number ) {
    return this.#http.get<GetLinkResponse>(this.#url + 'Links/GetOneDetails/' + linkId).pipe(
      map(response => response.link)
    )
  }

  getLinksByCategory( categoryId : number ) {
    return this.#http.get<GetLinksResponse>(`${this.#url}Links/GetByCategory/${categoryId}`).pipe(
      map(response => response.links)
    )
  }

  getCategoryDetails( categoryId : number ) {
    return this.#http.get<GetLinkCategoryResponse>(`${this.#url}LinkCategories/GetOneDetails/${categoryId}`).pipe(
      map(response => response.linkCategory)
    )
  }

  linksEditionFlow$ = combineLatest([
    this.selectedCategoryId$,
    this.linkCategories$,
    this.selectedLinkId$
  ]).pipe(
    switchMap(([selectedCategoryId, linkCategories, selectedLinkId]) => 
    {
      const links$ = selectedCategoryId === null 
        ? this.links$
        : this.getLinksByCategory(selectedCategoryId)

      const categoryDetails$ = selectedCategoryId === null 
        ? of(null)
        : this.getCategoryDetails(selectedCategoryId)

      const link$ = selectedLinkId === null 
        ? of(null)
        : this.getLink(selectedLinkId)

      return combineLatest([links$, categoryDetails$, link$]).pipe(
        map(([links, categoryDetails, link]) => ({
          links,
          linkCategories,
          categoryDetails,
          link
        }))
      )
    })
  )
  linksEditionFlow = toSignal(this.linksEditionFlow$, { initialValue: { links: [], linkCategories: [], categoryDetails: null, link: null } })

  public CreateLink( form : LinkCreateForm )
  {
    return this.#http.post<CreateLinkResponse>(`${this.#url}Links/Create`, form).pipe(
      tap( () => this.updateSelectedCategory(null) )
    )
  }

  public UpdateLink( form : LinkUpdateForm )
  {
    return this.#http.put<BaseResponse>(`${this.#url}Links/Update`, form).pipe(
      tap( () => 
        {
          this.updateSelectedLink(form.linkId)
        })
    )
  }

  public DeleteLink( linkId : number )
  {
    return this.#http.delete<BaseResponse>(`${this.#url}Links/Delete/` + linkId).pipe(
      tap( () => 
      {
        this.updateSelectedLink(null)
        this.updateSelectedCategory(null)
      })
    )
  }
}