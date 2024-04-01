import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { GetModelsByFranchiseResponse, GetModelsByMoodResponse, GetOneModelDetailsResponse } from '../../models/model';

@Injectable({
  providedIn: 'root'
})
export class ModelService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Models/'  

  // Get One Details

  public GetOneDetails( modelId : number ) : Observable<GetOneModelDetailsResponse>
  {
    return this.#http.get<GetOneModelDetailsResponse>(this.#url + 'GetOneDetails/' + modelId)
  }

  // Get By Mood

  public GetByMood( moodId : number ) : Observable<GetModelsByMoodResponse>
  {
    return this.#http.get<GetModelsByMoodResponse>(this.#url + 'GetByMood/' + moodId)
  }

  // Get By Franchise

  public GetByFranchise( franchiseId : number ) : Observable<GetModelsByFranchiseResponse>
  {
    return this.#http.get<GetModelsByFranchiseResponse>(this.#url + 'GetByFranchise/' + franchiseId)
  }

}