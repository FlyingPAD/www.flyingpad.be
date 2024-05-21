import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, catchError, combineLatest, map, of, shareReplay, startWith, switchMap } from 'rxjs';
import { environment } from '../../../environments/environment';
import { GetAllLinksResponse, Link, LinksGetByCategoryResponse } from '../models/link';
import { toSignal } from '@angular/core/rxjs-interop';
import { LinkCategoriesGetAllResponse, LinkCategoryFull, LinkCategoryLight } from '../models/link-category';

@Injectable({
  providedIn: 'root'
})
export class LinksService 
{
  // Injections :

  #http = inject(HttpClient)

  // Properties :

  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedCategoryId = new BehaviorSubject<number | null>(null)
  selectedCategoryId$ = this.#selectedCategoryId.asObservable()

  // Getters

  links$ = this.#http.get<GetAllLinksResponse>(this.#url + 'Links/GetAll').pipe(
    map(x => x.linksList),
    startWith([]),
    catchError(error => 
    {
      console.error('Error fetching links', error)
      return of([])
    }),
    shareReplay(1)
  )
  links = toSignal(this.links$, { initialValue : [] as Link[] })

  linksByCategoryWithDetails$ = this.selectedCategoryId$.pipe(
    switchMap(categoryId => {
        // return all links if no category
        if (!categoryId) 
        {
          return this.links$.pipe(
              map(linksList => ({
                  categoryDetails: null,
                  linksListByCategory: linksList
              }))
          )
        }
        // return all links per category
        return combineLatest([
            this.#http.get<LinkCategoryFull>(`${this.#url}LinkCategories/GetOneDetails/${categoryId}`),
            this.#http.get<LinksGetByCategoryResponse>(`${this.#url}Links/GetByCategory/${categoryId}`)
        ]).pipe(
            map(([categoryDetails, linksResponse]) => ({
                categoryDetails,
                linksListByCategory: linksResponse.linksListByCategory
            })),
            catchError(error => 
              {
                console.error('Error fetching data', error);
                return of({ categoryDetails: null, linksListByCategory: [] })
            })
        )
    }),
    shareReplay(1)
  )
  linksByCategoryWithDetails = toSignal(this.linksByCategoryWithDetails$, { initialValue: { categoryDetails: null, linksListByCategory: [] } })


  linkCategories$ = this.#http.get<LinkCategoriesGetAllResponse>(this.#url + 'LinkCategories/GetAll').pipe(
    map(x => x.linkCategories),
    startWith([]),
    catchError(error => 
    {
      console.error('Error fetching links', error)
      return of([])
    }),
    shareReplay(1)
  )
  linkCategories = toSignal(this.linkCategories$, { initialValue : [] as LinkCategoryLight[] })

  // Combined State

  combinedState$ = combineLatest(
    [
      this.links$,
      this.linkCategories$,
      this.selectedCategoryId$,
      this.linksByCategoryWithDetails$
    ])
    .pipe(shareReplay(1))

    combinedState = toSignal(this.combinedState$, { initialValue: [[], [], null, { categoryDetails: null, linksListByCategory: [] }] });

  updateSelectedCategory(categoryId : number | null) 
  {
    this.#selectedCategoryId.next(categoryId)
  }
}