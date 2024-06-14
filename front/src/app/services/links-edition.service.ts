import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { BehaviorSubject, combineLatest, of } from 'rxjs';
import { map, switchMap, tap } from 'rxjs/operators';
import { CreateLinkResponse, GetAllLinkCategoriesResponse, GetAllLinksResponse, GetLinksByCategoryResponse, GetOneLinkCategoryDetailsResponse, GetOneLinkDetailsResponse, LinkCreateForm, LinkUpdateForm, getLinkCategoriesCheckBoxesResponse } from '../core/models/link';
import { toSignal } from '@angular/core/rxjs-interop';
import { BaseResponse } from '../core/models/base-response';

@Injectable({
  providedIn: 'root'
})
export class LinksEditionService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedLinkId = new BehaviorSubject<number | null>(null)
  selectedLinkId$ = this.#selectedLinkId.asObservable()
  updateSelectedLink(linkId : number | null) 
  {
    this.#selectedLinkId.next(linkId)
  }

  #selectedCategoryId = new BehaviorSubject<number | null>(null)
  selectedCategoryId$ = this.#selectedCategoryId.asObservable()
  updateSelectedCategory(categoryId : number | null) 
  {
    this.#selectedCategoryId.next(categoryId)
  }

  linkCategories$ = this.#http.get<GetAllLinkCategoriesResponse>(this.#url + 'LinkCategories/GetAll').pipe(
    map(x => x.linkCategories)
  )

  links$ = this.#http.get<GetAllLinksResponse>(this.#url + 'Links/GetAll').pipe(
    map(x => x.linksList)
  )

  getLink( linkId : number )
  {
    return this.#http.get<GetOneLinkDetailsResponse>(this.#url + 'Links/GetOneDetails/' + linkId).pipe(
      map(response => response.link)
    )
  }

  getLinksByCategory( categoryId : number )
  {
    return this.#http.get<GetLinksByCategoryResponse>(`${this.#url}Links/GetByCategory/${categoryId}`).pipe(
      map(response => response.linksListByCategory)
    )
  }

  getCategoryDetails( categoryId : number )
  {
    return this.#http.get<GetOneLinkCategoryDetailsResponse>(`${this.#url}LinkCategories/GetOneDetails/${categoryId}`).pipe(
      map(response => response.linkCategory)
    )
  }

  getLinkCategoriesCheckBoxes( linkId : number )
  {
    return this.#http.get<getLinkCategoriesCheckBoxesResponse>(`${this.#url}LinkCategories/GetCheckBoxesByLink/${linkId}`)
  }

  // Flow
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
  // Signal
  linksEditionFlow = toSignal(this.linksEditionFlow$, { initialValue: { links: [], linkCategories: [], categoryDetails: null, link: null } })

  // Create Link
  public CreateLink( form : LinkCreateForm )
  {
    return this.#http.post<CreateLinkResponse>(`${this.#url}Links/Create`, form).pipe(
      tap( () => this.updateSelectedCategory(null) )
    )
  }

  // Update Link
  public UpdateLink( form : LinkUpdateForm )
  {
    return this.#http.put<BaseResponse>(`${this.#url}Links/Update`, form).pipe(
      tap( () => 
        {
          this.updateSelectedLink(form.businessId)
        })
    )
  }

  // Delete Link
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