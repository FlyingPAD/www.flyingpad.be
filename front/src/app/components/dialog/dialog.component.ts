import { Component, inject } from '@angular/core';
import { MoodsGalleryService } from '../../services/moods-gallery.service';

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrl: './dialog.component.scss'
})
export class DialogComponent {
  #moodsGalleryService = inject(MoodsGalleryService)

  public entityInfoToggle = this.#moodsGalleryService.entityInfoToggle
}