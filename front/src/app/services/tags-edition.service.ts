import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject, combineLatest, map, of, switchMap, tap } from 'rxjs';
import { environment } from '../../environments/environment';
import { CreateTagResponse, GetAllTagCategoriesResponse, GetAllTagsResponse, GetOneTagCategoryDetailsResponse, GetOneTagDetailsResponse, GetTagsByCategoryResponse, TagCreateForm } from '../core/models/tag';
import { BaseResponse } from '../core/models/base-response';

@Injectable({
  providedIn: 'root'
})
export class TagsEditionService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedTagId = new BehaviorSubject<number | null>(null)
  selectedTagId$ = this.#selectedTagId.asObservable()
  updateSelectedTag(tagId : number | null) 
  {
    this.#selectedTagId.next(tagId)
  }

  #selectedCategoryId = new BehaviorSubject<number | null>(null)
  selectedCategoryId$ = this.#selectedCategoryId.asObservable()
  updateSelectedCategory(categoryId : number | null) 
  {
    this.#selectedCategoryId.next(categoryId)
  }

  tagCategories$ = this.#http.get<GetAllTagCategoriesResponse>(this.#url + 'TagCategories/GetAll').pipe(
    map(x => x.tagCategories)
  )

  tags$ = this.#http.get<GetAllTagsResponse>(this.#url + 'Tags/GetAll').pipe(
    map(x => x.tags)
  )

  getTag( tagId : number )
  {
    return this.#http.get<GetOneTagDetailsResponse>(this.#url + 'Tags/GetOneDetails/' + tagId).pipe(
      map(response => response.tag)
    )
  }

  public getTagsByCategory(categoryId: number) 
  {
    const url = `${this.#url}Tags/GetByCategory/${categoryId}`;
    return this.#http.get<GetTagsByCategoryResponse>(url).pipe(
      map(response => response.tags)
    )
  }

  getCategoryDetails( categoryId : number )
  {
    return this.#http.get<GetOneTagCategoryDetailsResponse>(this.#url + 'TagCategories/GetById/' + categoryId).pipe(
      map(response => response.tagCategory)
    )
  }

  // Flow
  tagsEditionFlow$ = combineLatest([
    this.selectedCategoryId$,
    this.tagCategories$,
    this.selectedTagId$
  ]).pipe(
    switchMap(([selectedCategoryId, tagCategories, selectedTagId]) => 
    {
      const tags$ = selectedCategoryId === null 
        ? this.tags$
        : this.getTagsByCategory(selectedCategoryId)

      const categoryDetails$ = selectedCategoryId === null 
        ? of(null)
        : this.getCategoryDetails(selectedCategoryId)

      const tag$ = selectedTagId === null 
        ? of(null)
        : this.getTag(selectedTagId)

      return combineLatest([tags$, categoryDetails$, tag$]).pipe(
        map(([tags, categoryDetails, tag]) => ({
          tags,
          tagCategories,
          categoryDetails,
          tag
        }))
      )
    })
  )
  // Signal
  tagsEditionFlow = toSignal(this.tagsEditionFlow$, { initialValue: { tags: [], tagCategories: [], categoryDetails: null, tag: null } })

  // Create Tag
  public CreateTag( form : TagCreateForm )
  {
    return this.#http.post<CreateTagResponse>(`${this.#url}Tags/Create`, form).pipe(
      tap( () => this.updateSelectedCategory(null) )
    )
  }

  // Update Tag
  public UpdateTag( form : TagCreateForm )
  {
    return this.#http.put<BaseResponse>(`${this.#url}Tags/Update`, form)
  }

  // Delete Tag
  public DeleteTag( tagId : number )
  {
    return this.#http.delete<BaseResponse>(`${this.#url}Tags/Delete/` + tagId).pipe(
      tap( () => 
      {
        this.updateSelectedTag(null)
        this.updateSelectedCategory(null)
      })
    )
  }
}
