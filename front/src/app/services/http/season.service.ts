import { inject, Injectable } from '@angular/core';
import { GetCurrentSeasonResponse, Season } from '../../interfaces/season';
import { map, Observable, tap } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { NotificationService } from '../user-interface/notification.service';

@Injectable({
  providedIn: 'root'
})
export class SeasonService {
  #http = inject(HttpClient)
  #notificationService = inject(NotificationService)

  #url: string = environment.apiBaseUrl + '/api/V1/'

  public getCurrentSeason(): Observable<Season> {
    return this.#http.get<GetCurrentSeasonResponse>(`${this.#url}Seasons/GetCurrentSeason`).pipe(
      tap((response) => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.currentSeason))
  }
}