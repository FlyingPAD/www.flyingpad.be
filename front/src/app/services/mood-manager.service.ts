import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MoodManagerService {
  #selectedMoods = new BehaviorSubject<number[]>([])
  public selectedMoods = toSignal(this.#selectedMoods) as Signal<number[]>

  public selectionToggle(moodId: number): void {
    const currentMoods = this.#selectedMoods.value
    const index = currentMoods.indexOf(moodId)

    let newSelection: number[]

    if (index === -1) newSelection = [...currentMoods, moodId]
    else newSelection = currentMoods.filter(id => id !== moodId)

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
}