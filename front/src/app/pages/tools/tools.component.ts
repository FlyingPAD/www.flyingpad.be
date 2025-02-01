import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';
import { ToolsService } from '../../services/tools.service';

@Component({
  selector: 'app-tools',
  templateUrl: './tools.component.html',
  styleUrl: './tools.component.scss'
})
export class ToolsComponent {
  #toolsService = inject(ToolsService)
  #imageURLService = inject(ImageUrlService)

  public toolsMenuState = this.#toolsService.toolsMenuState

  public updateMenuState(menuState: string): void {
    this.#toolsService.updateToolsMenuState(menuState)
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}