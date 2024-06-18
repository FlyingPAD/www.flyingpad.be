import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment.prod';
import { map } from 'rxjs';
import { TagsGetFullListResponse } from '../models/tag';

@Injectable({
  providedIn: 'root'
})
export class TagsService 
{
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'    

  getAll()
  {
    return this.#http.get<TagsGetFullListResponse>(this.#url + 'Tags/GetTagsList').pipe(
      map(x => x.categoriesWithTags)
    )
  }
}
