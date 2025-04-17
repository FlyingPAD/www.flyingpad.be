import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/user-interface/scripts.service';
import { ScriptsViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-harmonic-arsenal',
  templateUrl: './harmonic-arsenal.component.html',
  styleUrl: './harmonic-arsenal.component.scss'
})
export class HarmonicArsenalComponent {
  #scriptsService = inject(ScriptsService)

  public viewModes = ScriptsViewMode

  public setViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsService.setScriptsViewMode(viewMode)
  }
}