import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/user-interface/scripts.service';
import { ScriptsViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-music-arsenal',
  templateUrl: './music-arsenal.component.html',
  styleUrl: './music-arsenal.component.scss'
})
export class MusicArsenalComponent {
  #scriptsService = inject(ScriptsService)

  public viewModes = ScriptsViewMode

  public setViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsService.setScriptsViewMode(viewMode)
  }
}