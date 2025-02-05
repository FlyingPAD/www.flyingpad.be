import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/scripts.service';

@Component({
  selector: 'app-melodic-arsenal',
  templateUrl: './melodic-arsenal.component.html',
  styleUrl: './melodic-arsenal.component.scss'
})
export class MelodicArsenalComponent {
  #scriptsService = inject(ScriptsService)

  public updateMenuState(menuState: string): void {
    this.#scriptsService.updateScriptMenuState(menuState)
  }
}