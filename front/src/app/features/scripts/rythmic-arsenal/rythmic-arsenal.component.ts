import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/scripts.service';
import { ScriptsViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-rythmic-arsenal',
  templateUrl: './rythmic-arsenal.component.html',
  styleUrl: './rythmic-arsenal.component.scss'
})
export class RythmicArsenalComponent {
  #scriptsService = inject(ScriptsService)

  public viewModes = ScriptsViewMode

  public setViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsService.setScriptsViewMode(viewMode)
  }
}