import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { GetOneVideoDetails } from '../../models/mood-video';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VideoService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Videos/'  

  // - Get One Details

  public GetOneDetails( businessId : number ) : Observable<GetOneVideoDetails>
  {
    return this.#http.get<GetOneVideoDetails>(this.#url + 'GetOneDetails/' + businessId)
  }
}