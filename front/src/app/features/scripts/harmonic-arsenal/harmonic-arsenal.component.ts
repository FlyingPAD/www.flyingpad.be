import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/scripts.service';

@Component({
  selector: 'app-harmonic-arsenal',
  templateUrl: './harmonic-arsenal.component.html',
  styleUrl: './harmonic-arsenal.component.scss'
})
export class HarmonicArsenalComponent {
  #scriptsService = inject(ScriptsService)

  public updateMenuState(menuState: string): void {
    this.#scriptsService.updateScriptMenuState(menuState)
  }
}