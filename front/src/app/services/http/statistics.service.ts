import { inject, Injectable, Signal } from '@angular/core';
import { catchError, map, Observable, of, shareReplay, startWith, Subject, switchMap, tap } from 'rxjs';
import { GetStatisticsResponse, Statistics } from '../../interfaces/statistics';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { toSignal } from '@angular/core/rxjs-interop';
import { NotificationService } from '../notification.service';

@Injectable({
  providedIn: 'root'
})
export class StatisticsService {
  #notificationService = inject(NotificationService)

  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  #refreshStatistics$ = new Subject<void>()

  #statistics$ = this.#refreshStatistics$.pipe(
    startWith(undefined),
    switchMap(() => this.getStatistics()),
    shareReplay(1)
  )

  public statistics: Signal<Statistics | undefined> = toSignal(this.#statistics$)

  public getStatistics(): Observable<Statistics | undefined> {
    return this.#http.get<GetStatisticsResponse>(`${this.#url}Statistics/GetStatistics/`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.statistics),
      catchError(() => of(undefined)))
  }

  public refreshStatistics(): void {
    this.#refreshStatistics$.next()
  }
}