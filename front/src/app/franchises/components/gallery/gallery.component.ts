import { Component, inject } from '@angular/core';
import { FranchiseStateService } from '../../../services/franchise.service';
import { ModelStateService } from '../../../services/model.service';
import { Router } from '@angular/router';
import { MoodStateService } from '../../../services/mood.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrl: './gallery.component.scss'
})
export class GalleryComponent 
{
  #franchisesService = inject(FranchiseStateService)
  #modelsService = inject(ModelStateService)
  #moodsService = inject(MoodStateService)
  #router = inject(Router)

  medias = this.#franchisesService.medias

  updateMediaId(mediaId : number | null)
  {
    this.#franchisesService.updateSelectedMediaId(mediaId)
    this.#router.navigateByUrl('franchises/media-gallery')
  }

  updateFranchiseId(franchiseId : number | null)
  {
    this.#franchisesService.updateSelectedFranchiseId(franchiseId)
    this.#moodsService.updateSelectedFranchiseId(franchiseId)
    this.#router.navigateByUrl('franchises/franchise-gallery')
  }

  updateModelId(modelId : number) : void
  {
    this.#modelsService.updateSelectedModelId(modelId)
    this.#moodsService.updateSelectedModelId(modelId)
    this.#router.navigateByUrl('models/model-gallery')
  }
}