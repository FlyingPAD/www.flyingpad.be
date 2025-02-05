import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/scripts.service';

@Component({
  selector: 'app-rythmic-arsenal',
  templateUrl: './rythmic-arsenal.component.html',
  styleUrl: './rythmic-arsenal.component.scss'
})
export class RythmicArsenalComponent {
  #scriptsService = inject(ScriptsService)

  public updateMenuState(menuState: string): void {
    this.#scriptsService.updateScriptMenuState(menuState)
  }
}