import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/scripts.service';

@Component({
  selector: 'app-the-octave',
  templateUrl: './the-octave.component.html',
  styleUrl: './the-octave.component.scss'
})
export class TheOctaveComponent {
  #scriptsService = inject(ScriptsService)

  public updateMenuState(page: string): void {
    this.#scriptsService.updateScriptMenuState(page)
  }
}