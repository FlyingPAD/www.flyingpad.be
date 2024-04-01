import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { LinkCategoriesCountResponse, LinkCategoriesGetAllResponse, LinkCategoriesGetOneResponse } from '../../models/link-category';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LinkCategoryService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'  

  // - Get All Link Categories

  public GetAll() : Observable<LinkCategoriesGetAllResponse>
  {
    return this.#http.get<LinkCategoriesGetAllResponse>(this.#url + 'LinkCategories/GetAll')
  }

  // - Get One Link Category With Details

  public GetOneDetails( categoryId : number ) : Observable<LinkCategoriesGetOneResponse> 
  {
    return this.#http.get<LinkCategoriesGetOneResponse>(this.#url + 'LinkCategories/GetOneDetails/' + categoryId)
  }

}