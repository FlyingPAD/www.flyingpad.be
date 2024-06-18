import { HttpClient } from '@angular/common/http';
import { Injectable, inject, signal } from '@angular/core';
import { of, map, tap } from 'rxjs';
import { LinkCategoryLight, GetAllLinkCategoriesResponse, GetAllLinksResponse, GetLinksByCategoryResponse, LinkForm } from '../models/link';

@Injectable({
  providedIn: 'root'
})
export class LinksService 
{
  #http = inject(HttpClient)
  #categories: LinkCategoryLight[] = []
  currentCategory = signal<LinkCategoryLight | undefined>(undefined)

  getCategories() {
    if(this.#categories.length > 0) return of(this.#categories);
    return this.#http.get<GetAllLinkCategoriesResponse>('https://back.flyingpad.be/api/v1/LinkCategories/GetAll').pipe(
      map(x => x.linkCategories),
      tap(categories => this.#categories = categories)
    );
  }

  getAll() {
    console.log('RE RUN')
    return this.#http.get<GetAllLinksResponse>('https://back.flyingpad.be/api/v1/links/GetAll').pipe(map(x => x.linksList));
  }

  getLinksByCategory(categoryId: number) {
    return this.#http.get<GetLinksByCategoryResponse>(`https://back.flyingpad.be/api/v1/links/GetByCategory/${categoryId}`).pipe(
      map(response => response.linksListByCategory),
    )
  }

  delete(linkId: number) {
    return this.#http.delete<GetAllLinksResponse>(`https://back.flyingpad.be/api/v1/links/delete/${linkId}`);
  }

  createOrUpdate(form: LinkForm, categoryId: string | undefined) {
    if(form.businessId) {
      return this.#http.put<GetAllLinksResponse>(`https://back.flyingpad.be/api/v1/links/update`, form);
    }
    console.log('selected Category', this.currentCategory())
    return this.#http.post<GetAllLinksResponse>(`https://back.flyingpad.be/api/v1/links/create`, {...form, categoryId});
  }
}