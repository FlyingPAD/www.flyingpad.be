import { Component, inject, Input } from '@angular/core';
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service';
import { ActiveEntity } from '../../enumerations/gallery-mode';

@Component({
  selector: 'app-dialog-info',
  templateUrl: './dialog-info.component.html',
  styleUrl: './dialog-info.component.scss'
})
export class DialogInfoComponent {
  #moodsGalleryService = inject(MoodsGalleryService)

  @Input() entity : any | undefined = undefined 
  @Input() moodsLength : number | undefined = undefined

  public activeEntity = this.#moodsGalleryService.activeEntity
  public activeEntities = ActiveEntity
}