import { Component, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { Router } from '@angular/router';
import { MoodService } from '../../../services/http/mood.service';
import { StateService } from '../../../services/custom-state/state.service';
import { MoodsGalleryService } from '../../../services/user-interface/moods-gallery.service';
import { GalleryType } from '../../../enumerations/gallery-type';
import { ActiveEntity, GalleryMode } from '../../../enumerations/gallery-mode';

@Component({
  selector: 'app-status',
  templateUrl: './status.component.html',
  styleUrl: './status.component.scss'
})
export class StatusComponent {
  #stateService = inject(StateService)
  #moodService = inject(MoodService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)

  public moodsFlow = this.#moodService.moodsFlow  
  public environment: string = environment.apiBaseUrl

  public goToMood(): void {
    this.#moodsGalleryService.setGalleryType(GalleryType.Details)
    this.#router.navigateByUrl('/central-gallery')
  }

  public goToTag(tagId: number): void {
    this.#stateService.setTagId(tagId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Tag)
    this.#router.navigateByUrl('/central-gallery')
  }

  public goToModel(modelId: number): void {
    this.#stateService.setModelId(modelId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Model)
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Model)
    this.#router.navigateByUrl('/central-gallery')
  }

  public goToArtist(artistId: number): void {
    this.#stateService.setArtistId(artistId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Artist)
    this.#router.navigateByUrl('/central-gallery')
  }

  public goToFranchise(franchiseId: number): void {
    this.#stateService.setFranchiseId(franchiseId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Franchise)
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Franchise)
    this.#router.navigateByUrl('/central-gallery')
  }
}