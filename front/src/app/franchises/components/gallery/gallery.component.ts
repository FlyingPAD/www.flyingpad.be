import { Component, inject } from '@angular/core';
import { FranchiseStateService } from '../../../core/services/franchise-state.service';
import { ModelStateService } from '../../../core/services/model-state.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrl: './gallery.component.scss'
})
export class GalleryComponent 
{
  #franchisesService = inject(FranchiseStateService)
  #modelsService = inject(ModelStateService)

  medias = this.#franchisesService.medias

  updateModelId(modelId : number) : void
  {
    this.#modelsService.updateSelectedModelId(modelId)
  }

  updateFranchiseId(franchiseId : number | null)
  {
    this.#franchisesService.updateSelectedFranchiseId(franchiseId)
  }

  updateMediaId(mediaId : number | null)
  {
    this.#franchisesService.updateSelectedMediaId(mediaId)
  }
}