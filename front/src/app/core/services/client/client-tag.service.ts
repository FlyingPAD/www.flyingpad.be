import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { TagsGetFullListResponse, GetOneTagDetails, TagsGetByMoodResponse } from '../../models/tag';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TagService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Tags/'  

  // - Get One Details

  public GetOneDetails( businesId : number ) : Observable<GetOneTagDetails> 
  {
    return this.#http.get<GetOneTagDetails>(this.#url + 'GetOneDetails/' + businesId)
  }

  //  - Get Full List of Tags with Categories

  public GetTagsList() : Observable<TagsGetFullListResponse>
  {
    return this.#http.get<TagsGetFullListResponse>(this.#url + 'GetTagsList')
  }

  //  - Get Mood Associated Tags

  public GetByMood( businessId : number ) : Observable<TagsGetByMoodResponse>
  {
    return this.#http.get<TagsGetByMoodResponse>(this.#url + 'GetByMood/' + businessId)
  }
}