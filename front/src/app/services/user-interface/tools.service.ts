import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';
import { ToolsViewMode } from '../../enumerations/view-modes';

@Injectable({
  providedIn: 'root'
})
export class ToolsService {
  #toolsViewMode$ = new BehaviorSubject<string>(ToolsViewMode.ChordWriter)

  public toolsViewMode = toSignal(this.#toolsViewMode$) as Signal<ToolsViewMode>

  public setToolsViewMode(viewMode: ToolsViewMode): void {
    this.#toolsViewMode$.next(viewMode)
  }
}