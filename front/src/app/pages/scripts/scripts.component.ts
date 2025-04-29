import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../services/user-interface/scripts.service';
import { ScriptsViewMode } from '../../enumerations/view-modes';

@Component({
  selector: 'app-scripts',
  templateUrl: './scripts.component.html',
  styleUrl: './scripts.component.scss'
})
export class ScriptsComponent {
  #scriptsService = inject(ScriptsService)

  public currentViewMode = this.#scriptsService.scriptsViewMode
  public viewModes = ScriptsViewMode
  
  public setViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsService.setScriptsViewMode(viewMode)
  }
}