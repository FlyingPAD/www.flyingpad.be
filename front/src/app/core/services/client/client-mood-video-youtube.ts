import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { GetOneVideoYoutubeDetailsResponse } from '../../models/mood-video-youtube';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VideoYouTubeService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/VideosYouTube/'  

  // - Get One Details

  public GetOneDetails( businessId : number ) : Observable<GetOneVideoYoutubeDetailsResponse>
  {
    return this.#http.get<GetOneVideoYoutubeDetailsResponse>(this.#url + 'GetOneDetails/' + businessId)
  }
}