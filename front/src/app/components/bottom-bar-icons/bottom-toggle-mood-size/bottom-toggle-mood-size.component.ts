import { Component, inject, Input } from '@angular/core';
import { MoodsGalleryService } from '../../../services/user-interface/moods-gallery.service';
import { DisplayService } from '../../../services/user-interface/display.service';
import { DisplayModes } from '../../../enumerations/display-modes';

@Component({
  selector: 'app-bottom-toggle-mood-size',
  templateUrl: './bottom-toggle-mood-size.component.html'
})
export class BottomToggleMoodSizeComponent {
  #moodsGalleryService = inject(MoodsGalleryService)
  #displayService = inject(DisplayService)

  @Input() moodType: number | undefined

  public moodSizeToggle = this.#moodsGalleryService.moodSizeToggle
  public displayInfo = this.#displayService.displayInfo

  public displayModes = DisplayModes
}