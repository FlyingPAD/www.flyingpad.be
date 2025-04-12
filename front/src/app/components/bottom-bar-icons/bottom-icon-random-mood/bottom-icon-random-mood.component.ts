import { Component, HostListener, inject } from '@angular/core';
import { StateService } from '../../../services/custom-state/state.service';
import { MoodsGalleryService } from '../../../services/moods-gallery.service';
import { GalleryMode } from '../../../enumerations/gallery-mode';
import { DisplayService } from '../../../services/display.service';
import { DisplayModes } from '../../../enumerations/display-modes';

@Component({
  selector: 'app-bottom-icon-random-mood',
  templateUrl: './bottom-icon-random-mood.component.html'
})
export class BottomIconRandomMoodComponent {
  #stateService = inject(StateService)
  #displayService = inject(DisplayService)
  #moodsGalleryService = inject(MoodsGalleryService)

  public displayInfo = this.#displayService.displayInfo
  public DisplayModes = DisplayModes

  public setMoodId(): void {
    this.#stateService.setMoodId(undefined)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Default)
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case '0':
        this.setMoodId()
        break
    }
  }
}