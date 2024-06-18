import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment.prod';
import { GetAllModelsResponse, Model } from '../models/models';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ModelsEditionService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  getAll() : Observable<Model[]> 
  {
    return this.#http.get<GetAllModelsResponse>(this.#url + 'Models/GetAll').pipe(
    map(response => response.models))
  }
}