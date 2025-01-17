import { Injectable, Signal } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class MoodsService {
  private moodMenuState$ = new BehaviorSubject<string>('gallery')
  public moodMenuState = toSignal(this.moodMenuState$) as Signal<string>
  public updateMoodMenuState(menuState : string): void {
    this.moodMenuState$.next(menuState)
  }
}