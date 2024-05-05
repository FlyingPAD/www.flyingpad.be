import { Injectable, inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { TagsGetFullListResponse } from '../models/tag';
import { map } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class TagStateService 
{
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'    

  tagsList$ = this.#http.get<TagsGetFullListResponse>(this.#url + 'Tags/GetTagsList').pipe(
    map(x => x.categoriesWithTags)
  )
  tagsList = toSignal(this.tagsList$, {initialValue : [] })


  
}