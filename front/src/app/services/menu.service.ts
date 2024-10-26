import { Injectable } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MenuService {
  #isLeftMenuOn = new BehaviorSubject<boolean>(false)
  public isLeftMenuOn = toSignal(this.#isLeftMenuOn)

  public toggleLeftMenu(): void {
    this.#isLeftMenuOn.next(!this.#isLeftMenuOn.value)
  }
  public openLeftMenu(): void {
    this.#isLeftMenuOn.next(true)
  }
  public closeLeftMenu(): void {
    this.#isLeftMenuOn.next(false)
  }
}