import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { GetLeaderBoardReponse, LeaderboardEntry } from '../../interfaces/leaderboard';
import { map, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LeaderboardService {
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public   getLeaderboard(): Observable<LeaderboardEntry[]> {
    return this.#http.get<GetLeaderBoardReponse>(`${this.#url}leaderBoard/GetLeaderBoard`).pipe(
      map(response => response.entries))
  }
}