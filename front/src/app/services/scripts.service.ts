import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ScriptsService {
  #scriptsMenuState = new BehaviorSubject<string>('introduction')

  public scriptsMenuState = toSignal(this.#scriptsMenuState) as Signal<string>

  public updateScriptMenuState(menuState: string): void {
    this.#scriptsMenuState.next(menuState)
  }
}