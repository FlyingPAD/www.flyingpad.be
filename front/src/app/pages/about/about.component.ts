import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/display/image-url.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrl: './about.component.scss'
})
export class AboutComponent {
  #imageURLService = inject(ImageUrlService)

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}