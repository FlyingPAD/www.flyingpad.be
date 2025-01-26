import { Injectable, Signal } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class MoodsService {
  #moodMenuState = new BehaviorSubject<string>('gallery')
  #editMoodMenuState = new BehaviorSubject<string>('info')

  public moodMenuState = toSignal(this.#moodMenuState) as Signal<string>
  public editMoodMenuState = toSignal(this.#editMoodMenuState) as Signal<string>

  public updateMoodMenuState(moodMenuState: string): void {
    this.#moodMenuState.next(moodMenuState)
  }
  public updateEditMoodMenuState(editMoodMenuState: string): void {
    this.#editMoodMenuState.next(editMoodMenuState)
  }
}