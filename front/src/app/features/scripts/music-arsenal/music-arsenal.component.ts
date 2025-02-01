import { Component, inject } from '@angular/core';
import { ScriptsService } from '../../../services/scripts.service';

@Component({
  selector: 'app-music-arsenal',
  templateUrl: './music-arsenal.component.html',
  styleUrl: './music-arsenal.component.scss'
})
export class MusicArsenalComponent {
    #scriptsService = inject(ScriptsService)
  
    public updateMenuState(menuState: string): void {
      this.#scriptsService.updateScriptMenuState(menuState)
    }
}