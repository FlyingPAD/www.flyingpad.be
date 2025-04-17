import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';
import { ScriptsViewMode } from '../../enumerations/view-modes';

@Injectable({
  providedIn: 'root'
})
export class ScriptsService {
  #scriptsViewMode$ = new BehaviorSubject<ScriptsViewMode>(ScriptsViewMode.Introduction)

  public scriptsViewMode = toSignal(this.#scriptsViewMode$) as Signal<ScriptsViewMode>

  public setScriptsViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsViewMode$.next(viewMode)
  }
}