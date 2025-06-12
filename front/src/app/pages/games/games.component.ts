import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/user-interface/image-url.service';

@Component({
  selector: 'app-games',
  templateUrl: './games.component.html',
  styleUrl: './games.component.scss'
})
export class GamesComponent {
  #imageURLService = inject(ImageUrlService)

  private readonly TOTAL_IMAGES: number = 1  // Adjust this number based on the total images you expect to load

  public isLoading: boolean = true
  public loadedImagesCount = 0

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }

  public onImageLoad(): void {
    this.loadedImagesCount++

    if (this.loadedImagesCount === this.TOTAL_IMAGES) this.isLoading = false
  }
}