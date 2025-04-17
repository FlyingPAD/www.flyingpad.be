import { Component, inject } from '@angular/core';
import { MoodsGalleryService } from '../../../services/user-interface/moods-gallery.service';
import { GalleryType } from '../../../enumerations/gallery-type';

@Component({
  selector: 'app-bottom-icon-moods',
  templateUrl: './bottom-icon-moods.component.html'
})
export class BottomIconMoodsComponent {
  #moodsGalleryService = inject(MoodsGalleryService)

  public backToGallery(): void {
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
  }
}