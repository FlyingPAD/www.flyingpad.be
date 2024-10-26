import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ImageUrlService } from '../../services/display/image-url.service';

@Component({
  selector: 'app-header-moods',
  templateUrl: './header-moods.component.html',
  styleUrl: './header-moods.component.scss'
})
export class HeaderMoodsComponent {
  @Output() menuToggle = new EventEmitter()
  #imageURLService = inject(ImageUrlService)

  public handleMenuToggle(): void {
    this.menuToggle.emit()
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}