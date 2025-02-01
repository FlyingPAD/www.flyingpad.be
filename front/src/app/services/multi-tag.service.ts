import { HttpClient } from '@angular/common/http';
import { Injectable, Signal, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { ArtistCheckBox, GetAllArtistsResponse } from '../interfaces/artist';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { GetModelsByMoodResponse, ModelCheckBox } from '../interfaces/model';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class MultiTagService {
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'
  
  #selectedMoods = new BehaviorSubject<number[]>([])
  public selectedMoods = toSignal(this.#selectedMoods) as Signal<number[]>

  private artists$ = this.getArtists()
  public artists = toSignal(this.artists$, { initialValue: [] }) as Signal<ArtistCheckBox[]>

  private models$ = this.getModels()
  public models = toSignal(this.models$, { initialValue: [] }) as Signal<ModelCheckBox[]>

  public getArtists(): Observable<ArtistCheckBox[]> {
    return this.#http.get<GetAllArtistsResponse>(`${this.#url}Artists/GetAll`).pipe(
      map(response => response.artists)
    )
  }
  public getModels(): Observable<ModelCheckBox[]> {
    return this.#http.get<GetModelsByMoodResponse>(`${this.#url}Models/GetAll`).pipe(
      map(response => response.models)
    )
  }

  public selectionToggle(moodId: number): void {
    const currentMoods = this.#selectedMoods.value
    const index = currentMoods.indexOf(moodId)
    
    let newSelection: number[]
  
    if (index === -1) {
      newSelection = [...currentMoods, moodId]
    } 
    else {
      newSelection = currentMoods.filter(id => id !== moodId)
    }
  
    this.#selectedMoods.next(newSelection)
  }

  public checkIfSelected(moodId: number): boolean {
    return this.selectedMoods().includes(moodId)
  }

  public resetSelection(): void {
    this.#selectedMoods.next([])
  }
}