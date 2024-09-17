import { Injectable } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RightColumnService {
  #rightColumnIsActive = new BehaviorSubject<boolean>(false)
  private rightColumnIsActive$ = this.#rightColumnIsActive.asObservable()
  public updateRightColumnState(isActive : boolean): void {this.#rightColumnIsActive.next(isActive)}
  public rightColumnIsActive = toSignal(this.rightColumnIsActive$)
}