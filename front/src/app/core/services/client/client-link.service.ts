import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { LinksCountResponse, LinksGetAllResponse, LinksGetByCategoryResponse } from '../../models/link';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LinkService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  // - Get All Links

  public GetAll() : Observable<LinksGetAllResponse>
  {
    return this.#http.get<LinksGetAllResponse>(this.#url + 'Links/GetAll')
  }

  // - Get Links by Category ID

  public GetByCategory( categoryId : number ) : Observable<LinksGetByCategoryResponse>
  {
    return this.#http.get<LinksGetByCategoryResponse>(this.#url + 'Links/GetByCategory/' + categoryId)
  }

}