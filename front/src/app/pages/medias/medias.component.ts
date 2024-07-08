import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { FranchiseStateService } from '../../services/franchise.service';
import { FlowService } from '../../services/flow.service';

@Component({
  selector: 'app-medias',
  templateUrl: './medias.component.html',
  styleUrl: './medias.component.scss'
})
export class MediasComponent {
    #flowService = inject(FlowService)
    #franchisesService = inject(FranchiseStateService)
    #router = inject(Router)  
    medias = this.#franchisesService.medias
  
    updateMediaId(mediaId: number): void {
      this.#flowService.updateMediaId(mediaId)
      this.#router.navigateByUrl('franchises/media-gallery')
    }  
    updateFranchiseId(franchiseId: number): void {
      this.#flowService.updateFranchiseId(franchiseId)
      this.#router.navigateByUrl('moods')
    }  
    updateModelId(modelId: number): void {
      this.#flowService.updateModelId(modelId)
      this.#router.navigateByUrl('moods')
    }
  }