import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { map } from 'rxjs';
import { environment } from '../../../environments/environment';
import { LinksGetAllResponse } from '../models/link';

@Injectable({
  providedIn: 'root'
})
export class LinksStateService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  // - Get All Links

  links$ = this.#http.get<LinksGetAllResponse>(this.#url + 'Links/GetAll').pipe(
    map(x => x.linksList)
  )
}