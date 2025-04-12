import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/scripts.service';
import { ScriptsViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-the-octave',
  templateUrl: './the-octave.component.html',
  styleUrl: './the-octave.component.scss'
})
export class TheOctaveComponent {
  #scriptsService = inject(ScriptsService)

  public viewModes = ScriptsViewMode

  public setViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsService.setScriptsViewMode(viewMode)
  }
}