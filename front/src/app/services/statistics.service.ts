import { inject, Injectable, Signal } from '@angular/core';
import { map, Observable } from 'rxjs';
import { GetStatisticsResponse, Statistics } from '../interfaces/statistics';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class StatisticsService {
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  private statistics$: Observable<Statistics> = this.#http.get<GetStatisticsResponse>(this.#url + "Statistics/GetStatistics/").pipe(
    map(response => response.statistics)
  )
  public statistics: Signal<Statistics | undefined> = toSignal(this.statistics$)

  public getStatistics(): void {
    this.statistics$ = this.#http.get<GetStatisticsResponse>(this.#url + "Statistics/GetStatistics/").pipe(
      map(response => response.statistics)
    )
  }
}