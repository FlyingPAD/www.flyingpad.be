import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/user-interface/image-url.service';

@Component({
  selector: 'app-games',
  templateUrl: './games.component.html',
  styleUrl: './games.component.scss'
})
export class GamesComponent {
  #imageURLService = inject(ImageUrlService)

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}