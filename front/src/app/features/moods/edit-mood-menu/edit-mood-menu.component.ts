import { Component, inject } from '@angular/core';
import { MoodsGalleryService } from '../../../services/moods-gallery.service';
import { EditMoodViewMode } from '../../../enumerations/view-modes-edition';

@Component({
  selector: 'app-edit-mood-menu',
  templateUrl: './edit-mood-menu.component.html',
  styleUrl: './edit-mood-menu.component.scss'
})
export class EditMoodMenuComponent {
  #moodsGalleryService = inject(MoodsGalleryService)

  public currentViewMode = this.#moodsGalleryService.editMoodViewMode
  public viewModes = EditMoodViewMode

  public setViewMode(viewMode: EditMoodViewMode): void {
    this.#moodsGalleryService.setEditMoodViewMode(viewMode)
  }
}