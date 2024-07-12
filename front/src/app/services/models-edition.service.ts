import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, map } from 'rxjs';
import { environment } from '../../environments/environment';
import { toSignal } from '@angular/core/rxjs-interop';
import { GetModelsResponse } from '../models/model';

@Injectable({
  providedIn: 'root'
})
export class ModelsEditionService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedModelId = new BehaviorSubject<number | null>(null)
  selectedModelId$ = this.#selectedModelId.asObservable()
  updateSelectedModelId( modelId : number | null ) : void 
  { 
    this.#selectedModelId.next(modelId) 
  }

  modelsEditionFlow$ = this.#http.get<GetModelsResponse>(this.#url + 'Models/GetAll').pipe(
    map(response => response.models)
  )
  modelsEditionFlow = toSignal(this.modelsEditionFlow$, { initialValue: [] });
}