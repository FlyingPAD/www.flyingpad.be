import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { GetAllArtistsResponse } from '../models/artist';
import { map } from 'rxjs';
import { GetAllModelsResponse } from '../models/model';

@Injectable({
  providedIn: 'root'
})
export class MultiTagService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'
  selectedMoods : number[] = []

  selectionToggle(moodId : number) : void
  {
    let index = this.selectedMoods.findIndex(x => x === moodId)
  
    if (index === -1) 
    {
      this.selectedMoods.push(moodId)
    } 
    else 
    {
      this.selectedMoods.splice(index, 1)
    }
  }
  
  checkIfSelected(moodId : number) : boolean
  {
    let index = this.selectedMoods.findIndex(x => x === moodId)
  
    if (index === -1) 
    {
      return false
    } 
    else 
    {
      return true
    }
  }

  getArtists()
  {
    return this.#http.get<GetAllArtistsResponse>(`${this.#url}Artists/GetAll`).pipe(
      map(response => response.artists)
    )
  }

  getModels()
  {
    return this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetAll`).pipe(
      map(response => response.models)
    )
  }

  reset()
  {
    this.selectedMoods = []
  }
}