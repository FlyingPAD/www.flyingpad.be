import { Injectable } from '@angular/core';
import { HttpClient, HttpBackend } from '@angular/common/http';
import { map, tap, catchError, throwError } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class SoundcloudService {
  private jsonpClient: HttpClient;

  constructor(
    private http: HttpClient,         // ton client « normal » avec interceptors
    private handler: HttpBackend      // le backend brut
  ) {
    // on construit un HttpClient vierge, sans passer par les interceptors
    this.jsonpClient = new HttpClient(handler);
  }

  getThumbnailUrl(trackUrl: string) {
    const cleanUrl = trackUrl.split('?')[0];
    const oembedUrl =
      `https://soundcloud.com/oembed?format=jsonp&url=${encodeURIComponent(cleanUrl)}`;

    return this.jsonpClient
      .jsonp<{ thumbnail_url: string }>(oembedUrl, 'callback')
      .pipe(
        tap(resp => console.log('[SoundcloudService] JSONP response →', resp)),
        map(resp => resp.thumbnail_url),
        catchError(err => {
          console.error('[SoundcloudService] JSONP error →', err);
          return throwError(() => err);
        })
      );
  }
}