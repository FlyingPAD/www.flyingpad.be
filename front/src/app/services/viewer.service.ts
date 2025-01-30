import { Injectable } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ViewerService {
  #moodHeight = new BehaviorSubject<number>(0)
  moodHeight$ = this.#moodHeight.asObservable()
  updatemoodHeight(moodHeight : number): void {this.#moodHeight.next(moodHeight)}
  moodHeight = toSignal(this.moodHeight$)

  getMoodHeight(state: boolean, windowHeight: number, moodHeight: number): void {
    let MOODHEIGHTMIN: number = windowHeight -64
    let MOODHEIGHTMAX: number = 2500

    if(state) {
      if(moodHeight < MOODHEIGHTMAX) {
        this.updatemoodHeight(moodHeight)
      }
      else {
        this.updatemoodHeight(MOODHEIGHTMAX)
      }
    }
    else {
      this.updatemoodHeight(MOODHEIGHTMIN)
    }
  }
}