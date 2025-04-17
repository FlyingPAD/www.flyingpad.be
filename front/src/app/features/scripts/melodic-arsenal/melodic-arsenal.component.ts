import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/user-interface/scripts.service';
import { ScriptsViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-melodic-arsenal',
  templateUrl: './melodic-arsenal.component.html',
  styleUrl: './melodic-arsenal.component.scss'
})
export class MelodicArsenalComponent {
  #scriptsService = inject(ScriptsService)

  public viewModes = ScriptsViewMode

  public setViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsService.setScriptsViewMode(viewMode)
  }
}