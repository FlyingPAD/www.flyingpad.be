import { HttpClient } from '@angular/common/http';
import { Injectable, Signal, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { ArtistCheckBox, GetAllArtistsResponse } from '../interfaces/artist';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { GetModelsByMoodResponse, ModelCheckBox } from '../interfaces/model';
import { toSignal } from '@angular/core/rxjs-interop';
import { MoodScoreUpdate } from '../interfaces/forms-update';
import { NotificationService } from './notification.service';
import { MoodService } from './http/mood.service';

@Injectable({
  providedIn: 'root'
})
export class MultiTagService {
  #http = inject(HttpClient)
  #moodService = inject(MoodService)
  #notificationService = inject(NotificationService)

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

  public selectAll(allMoodIds: number[]): void {
    this.#selectedMoods.next(allMoodIds)
  }

  public invertSelection(allMoodIds: number[]): void {
    const currentSelection = this.#selectedMoods.value
    const newSelection = allMoodIds.filter(moodId => !currentSelection.includes(moodId))
    this.#selectedMoods.next(newSelection)
  }

  public multiScore(score: number): void {
    const currentSelection = this.#selectedMoods.value

    if (currentSelection.length === 0) {
      this.#notificationService.warning('No Moods Selected')
    } else {
      currentSelection.forEach(moodId => {
        let form: MoodScoreUpdate = { moodId: moodId, value: score }
        this.#moodService.updateMoodScore(form)
      })
    }
  }
}