import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';
import { ToolsService } from '../../services/tools.service';
import { ToolsViewMode } from '../../enumerations/view-modes';

@Component({
  selector: 'app-tools',
  templateUrl: './tools.component.html',
  styleUrl: './tools.component.scss'
})
export class ToolsComponent {
  #toolsService = inject(ToolsService)
  #imageURLService = inject(ImageUrlService)

  public currentViewMode = this.#toolsService.toolsViewMode
  public viewModes = ToolsViewMode

  public setToolsViewMode(viewMode: ToolsViewMode): void {
    this.#toolsService.setToolsViewMode(viewMode)
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}