import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { VideoYouTubeDetails } from '../models/youtube-test';

@Injectable({
  providedIn: 'root'
})
export class VideoTestService {

  private apiUrl: string = 'https://www.googleapis.com/youtube/v3/videos';
  private apiKey: string = 'YOUR_API_KEY'; // Remplacez par votre clé API

  constructor(private http: HttpClient) { }

  getVideoDetails(videoId: string): Observable<VideoYouTubeDetails> 
  {
    const url = `${this.apiUrl}?id=${videoId}&key=${this.apiKey}`;
    return this.http.get<VideoYouTubeDetails>(url);
  }
}