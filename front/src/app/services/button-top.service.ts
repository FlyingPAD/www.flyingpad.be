import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ButtonTopService {
  #topButtonisActiveSubject$ = new BehaviorSubject<boolean>(false)
  #showButtonTopSubject$ = new BehaviorSubject<boolean>(false)

  public topButtonisActive = toSignal(this.#topButtonisActiveSubject$) as Signal<boolean>
  public showButtonTop = toSignal(this.#showButtonTopSubject$) as Signal<boolean>

  public updateTopButtonState(state: boolean): void {
    this.#topButtonisActiveSubject$.next(state)
  }
  
  public setShowButtonTop(state: boolean): void {
    this.#showButtonTopSubject$.next(state)

    if(!state) this.updateTopButtonState(false)
  }
}