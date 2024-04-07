import { Injectable, inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { GetMediasFullListResponse } from '../models/media';
import { map } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class FranchiseStateService 
{
    // Injections :

    #http = inject(HttpClient)

    // Properties :
  
    #url : string = environment.apiBaseUrl + '/api/V1/'


    medias$ = this.#http.get<GetMediasFullListResponse>(this.#url + 'Franchises/GetFranchisesList/').pipe(
      map(response => response.medias)
    )
    medias = toSignal(this.medias$, {initialValue : []})

}