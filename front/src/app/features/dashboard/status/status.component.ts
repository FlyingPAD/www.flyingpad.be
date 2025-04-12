import { Component, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { Router } from '@angular/router';
import { MoodService } from '../../../services/http/mood.service';
import { StateService } from '../../../services/custom-state/state.service';
import { MoodsGalleryService } from '../../../services/moods-gallery.service';
import { GalleryType } from '../../../enumerations/gallery-type';
import { GalleryMode } from '../../../enumerations/gallery-mode';
import { DisplayService } from '../../../services/display.service';
import { DisplayModes } from '../../../enumerations/display-modes';

@Component({
  selector: 'app-status',
  templateUrl: './status.component.html',
  styleUrl: './status.component.scss'
})
export class StatusComponent {
  #stateService = inject(StateService)
  #moodService = inject(MoodService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #displayService = inject(DisplayService)
  #router = inject(Router)

  public moodsFlow = this.#moodService.moodsFlow
  public displayInfo = this.#displayService.displayInfo
  public displayModes = DisplayModes
  
  public environment: string = environment.apiBaseUrl

  public goToCurrentMood(): void {
    this.#moodsGalleryService.setGalleryType(GalleryType.Details)
    this.#router.navigateByUrl('/central-gallery')
  }

  public goToCurrentTag(tagId: number): void {
    this.#stateService.setTagId(tagId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Tag)
    this.#router.navigateByUrl('/central-gallery')
  }
}