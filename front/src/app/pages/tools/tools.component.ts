import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/user-interface/image-url.service';
import { ToolsService } from '../../services/user-interface/tools.service';
import { ToolsViewMode } from '../../enumerations/view-modes';

@Component({
  selector: 'app-tools',
  templateUrl: './tools.component.html',
  styleUrl: './tools.component.scss'
})
export class ToolsComponent {
  #toolsService = inject(ToolsService)
  #imageURLService = inject(ImageUrlService)

  private readonly TOTAL_IMAGES: number  = 3  // Adjust this number based on the total images you expect to load
  
  public isLoading: boolean = true
  public loadedImagesCount = 0

  public currentViewMode = this.#toolsService.toolsViewMode
  public viewModes = ToolsViewMode

  public setToolsViewMode(viewMode: ToolsViewMode): void {
    this.#toolsService.setToolsViewMode(viewMode)
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }

  public onImageLoad(): void {
    this.loadedImagesCount++

    if (this.loadedImagesCount === this.TOTAL_IMAGES) this.isLoading = false
  }
}