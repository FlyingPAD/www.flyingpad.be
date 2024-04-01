import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { GetFranchisesByModelResponse, GetFranchisesByMoodResponse, GetOneFranchiseDetailsResponse } from '../../models/franchise';

@Injectable({
  providedIn: 'root'
})
export class FranchiseService
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Franchises/'  

  public GetOneDetails( franchiseId : number) : Observable<GetOneFranchiseDetailsResponse>
  {
    return this.#http.get<GetOneFranchiseDetailsResponse>(this.#url + 'GetOneDetails/' +  franchiseId)
  }

  public GetByMood( moodId : number) : Observable<GetFranchisesByMoodResponse>
  {
    return this.#http.get<GetFranchisesByMoodResponse>(this.#url + 'GetByMood/' +  moodId)
  }

  public GetByModel( modelId : number) : Observable<GetFranchisesByModelResponse>
  {
    return this.#http.get<GetFranchisesByModelResponse>(this.#url + 'GetByModel/' +  modelId)
  }
}