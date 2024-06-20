import { HttpClient } from '@angular/common/http';
import { Injectable, inject, signal } from '@angular/core';
import { of, map, tap } from 'rxjs';
import { LinkCategoryLight, GetAllLinkCategoriesResponse, GetAllLinksResponse, GetLinksByCategoryResponse, LinkForm } from '../models/link';
import { environment } from '../../environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class LinksService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'    
  
  #categories: LinkCategoryLight[] = []
  currentCategory = signal<LinkCategoryLight | undefined>(undefined)

  getCategories() {
    if(this.#categories.length > 0) return of(this.#categories);
    return this.#http.get<GetAllLinkCategoriesResponse>(this.#url + 'LinkCategories/GetAll').pipe(
      map(x => x.linkCategories),
      tap(categories => this.#categories = categories)
    );
  }

  getAll() {
    console.log('RE RUN')
    return this.#http.get<GetAllLinksResponse>(`${this.#url}links/GetAll`).pipe(map(x => x.linksList));
  }

  getLinksByCategory(categoryId: number) {
    return this.#http.get<GetLinksByCategoryResponse>(`${this.#url}links/GetByCategory/${categoryId}`).pipe(
      map(response => response.linksListByCategory),
    )
  }

  delete(linkId: number) {
    return this.#http.delete<GetAllLinksResponse>(`${this.#url}links/delete/${linkId}`);
  }

  createOrUpdate(form: LinkForm, categoryId: string | undefined) {
    if(form.businessId) {
      return this.#http.put<GetAllLinksResponse>(`${this.#url}links/update`, form);
    }
    console.log('selected Category', this.currentCategory())
    return this.#http.post<GetAllLinksResponse>(`${this.#url}links/create`, {...form, categoryId});
  }
}