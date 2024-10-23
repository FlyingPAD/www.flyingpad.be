import { Injectable } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RightColumnService {
  #rightColumnIsActive = new BehaviorSubject<boolean>(false)
  public rightColumnIsActive = toSignal(this.#rightColumnIsActive)
  public toggleRightColumn(): void {
    let value = this.#rightColumnIsActive.value
    this.#rightColumnIsActive.next(!value)
  }
  public enableRightColumn(): void {
    this.#rightColumnIsActive.next(true)
  }
  public disableRightColumn(): void {
    this.#rightColumnIsActive.next(false)
  }
}