import { Injectable } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MenuService {
  #isLeftMenuOn = new BehaviorSubject<boolean>(false)
  public isLeftMenuOn = toSignal(this.#isLeftMenuOn)

  #isRightMenuOn = new BehaviorSubject<boolean>(false)
  public isRightMenuOn = toSignal(this.#isRightMenuOn)

  public toggleLeftMenu(): void {
    this.#isLeftMenuOn.next(!this.#isLeftMenuOn.value)
  }

  public closeLeftMenu(): void {
    this.#isLeftMenuOn.next(false)
  }

  public toggleRightMenu(): void {
    this.#isRightMenuOn.next(!this.#isRightMenuOn.value)
  }

  public openRightMenu(): void {
    this.#isRightMenuOn.next(true)
  }
  
  public closeRightMenu(): void {
    this.#isRightMenuOn.next(false)
  }
}