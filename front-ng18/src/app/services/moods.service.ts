import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment.prod';
import { GetAllMoodsResponse } from '../models/mood';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MoodsService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'    

  getAll() {
    console.log('RE RUN')
    return this.#http.get<GetAllMoodsResponse>(`${this.#url}moods/getall`).pipe(map(x => x.moodsList));
  }
}
