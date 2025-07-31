import { Component, inject } from '@angular/core';
import { ScriptsViewMode } from '../../../enumerations/view-modes';
import { ScriptsService } from '../../../services/user-interface/scripts.service';

@Component({
  selector: 'app-chords',
  templateUrl: './chords.component.html',
  styleUrl: './chords.component.scss'
})
export class ChordsComponent {
  #scriptsService = inject(ScriptsService)

  public viewModes = ScriptsViewMode

  public setViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsService.setScriptsViewMode(viewMode)
  }
}