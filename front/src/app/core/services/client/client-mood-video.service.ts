import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { GetOneVideoDetailsResponse } from '../../models/mood-video';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VideoService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Videos/'  

  // - Get One Details

  public GetOneDetails( businessId : number ) : Observable<GetOneVideoDetailsResponse>
  {
    return this.#http.get<GetOneVideoDetailsResponse>(this.#url + 'GetOneDetails/' + businessId)
  }
}