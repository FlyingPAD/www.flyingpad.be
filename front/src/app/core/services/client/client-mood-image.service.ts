import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { GetOneImageDetailsResponse } from '../../models/mood-image';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ImageService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Images/'  

  // - Get One Details

  public GetOneDetails( businessId : number ) : Observable<GetOneImageDetailsResponse>
  {
    return this.#http.get<GetOneImageDetailsResponse>(this.#url + 'GetOneDetails/' + businessId)
  }
}