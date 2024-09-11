import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';
import { GetMediasListResponse } from '../models/franchise';

@Injectable({
  providedIn: 'root'
})
export class FranchiseStateService 
{
    #http = inject(HttpClient) 
    #url : string = environment.apiBaseUrl + '/api/V1/'

    medias$ = this.#http.get<GetMediasListResponse>(this.#url + 'Franchises/GetFranchisesList').pipe(
      map(response => response.medias)
    )
    medias = toSignal( this.medias$, { initialValue : [] } )

}