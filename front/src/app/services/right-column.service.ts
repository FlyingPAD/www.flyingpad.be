import { Injectable } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RightColumnService {
  #rightColumnIsActive = new BehaviorSubject<boolean>(false)
  rightColumnIsActive$ = this.#rightColumnIsActive.asObservable()
  updateRightColumnState(isActive : boolean): void {this.#rightColumnIsActive.next(isActive)}
  rightColumnIsActive = toSignal(this.rightColumnIsActive$)
}