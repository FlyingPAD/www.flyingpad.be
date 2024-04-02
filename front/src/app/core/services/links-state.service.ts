import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { map, shareReplay } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Link, LinksGetAllResponse } from '../models/link';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class LinksStateService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  // - Get All Links

  links$ = this.#http.get<LinksGetAllResponse>(this.#url + 'Links/GetAll').pipe(
    map(x => x.linksList),
    shareReplay(1)
  )
  links = toSignal(this.links$, { initialValue : [] as Link[] })
}