import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { GetOneVideoYouTubeDetails } from '../../models/mood-video-youtube';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VideoYouTubeService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/VideosYouTube/'  

  // - Get One Details

  public GetOneDetails( businessId : number ) : Observable<GetOneVideoYouTubeDetails>
  {
    return this.#http.get<GetOneVideoYouTubeDetails>(this.#url + 'GetOneDetails/' + businessId)
  }
}