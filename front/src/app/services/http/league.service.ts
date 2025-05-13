import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { map, Observable } from 'rxjs';
import { GetLeagueByNameResponse, LeagueWithRankingDto } from '../../interfaces/league';

@Injectable({
  providedIn: 'root'
})
export class LeagueService {
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public getLeagueByName(leagueName: string): Observable<LeagueWithRankingDto> {
    return this.#http.get<GetLeagueByNameResponse>(`${this.#url}leagues/GetLeagueByName/${leagueName}`).pipe(
      map(response => response.league))
  }
}