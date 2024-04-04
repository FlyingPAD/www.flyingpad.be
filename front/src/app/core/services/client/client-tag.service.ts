import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { TagsGetFullListResponse, GetOneTagDetailsResponse, GetTagsByMoodResponse } from '../../models/tag';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TagService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Tags/'  

  // - Get One Details

  public GetOneDetails( businesId : number ) : Observable<GetOneTagDetailsResponse> 
  {
    return this.#http.get<GetOneTagDetailsResponse>(this.#url + 'GetOneDetails/' + businesId)
  }

  //  - Get Full List of Tags with Categories

  public GetTagsList() : Observable<TagsGetFullListResponse>
  {
    return this.#http.get<TagsGetFullListResponse>(this.#url + 'GetTagsList')
  }

  //  - Get Mood Associated Tags

  public GetByMood( businessId : number ) : Observable<GetTagsByMoodResponse>
  {
    return this.#http.get<GetTagsByMoodResponse>(this.#url + 'GetByMood/' + businessId)
  }
}