import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment.prod';
import { CreateModelResponse, GetAllModelsResponse, Model, ModelForm } from '../models/model';
import { Observable, map } from 'rxjs';
import { BaseResponse } from '../models/base-response';

@Injectable({
  providedIn: 'root'
})
export class ModelsEditionService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  getAll() : Observable<Model[]> 
  {
    return this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetAll`).pipe(
    map(response => response.models))
  }

  delete(modelId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Models/delete/${modelId}`);
  }

  createOrUpdate(form: ModelForm) {
    if(form.businessId) {
      return this.#http.put<BaseResponse>(`${this.#url}Models/update`, form);
    }
    return this.#http.post<CreateModelResponse>(`${this.#url}Models/create`, {...form});
  }
}