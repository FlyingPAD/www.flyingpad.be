import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ToolsService {
  #toolsMenuState = new BehaviorSubject<string>('circle-of-fifths')

  public toolsMenuState = toSignal(this.#toolsMenuState) as Signal<string>

  public updateToolsMenuState(menuState: string): void {
    this.#toolsMenuState.next(menuState)
  }
}