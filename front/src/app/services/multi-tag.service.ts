import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { ArtistCheckBox, GetAllArtistsResponse } from '../interfaces/artist';
import { map, Observable } from 'rxjs';
import { GetModelsByMoodResponse, ModelCheckBox } from '../interfaces/model';

@Injectable({
  providedIn: 'root'
})
export class MultiTagService {
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'
  selectedMoods: number[] = []

  selectionToggle(moodId: number): void {
    let index = this.selectedMoods.findIndex(x => x === moodId)

    if (index === -1) {
      this.selectedMoods.push(moodId)
    }
    else {
      this.selectedMoods.splice(index, 1)
    }
  }

  checkIfSelected(moodId: number): boolean {
    let index = this.selectedMoods.findIndex(x => x === moodId)

    if (index === -1) {
      return false
    }
    else {
      return true
    }
  }

  getArtists(): Observable<ArtistCheckBox[]> {
    return this.#http.get<GetAllArtistsResponse>(`${this.#url}Artists/GetAll`).pipe(
      map(response => response.artists)
    )
  }

  getModels(): Observable<ModelCheckBox[]> {
    return this.#http.get<GetModelsByMoodResponse>(`${this.#url}Models/GetAll`).pipe(
      map(response => response.models)
    )
  }

  reset(): void {
    this.selectedMoods = []
  }
}