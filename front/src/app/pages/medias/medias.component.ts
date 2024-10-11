import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { FlowService } from '../../services/flow.service';

@Component({
  selector: 'app-medias',
  templateUrl: './medias.component.html',
  styleUrl: './medias.component.scss'
})
export class MediasComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  flow = this.#flowService.flow

  updateMediaId(mediaId: number): void {
    this.#flowService.updateMediumId(mediaId)
    this.#router.navigateByUrl('/medium-gallery')
  }
  updateFranchiseId(franchiseId: number): void {
    this.#flowService.updateFranchiseId(franchiseId)
    this.#router.navigateByUrl('/moods')
  }
  updateModelId(modelId: number): void {
    this.#flowService.updateModelId(modelId)
    this.#router.navigateByUrl('/moods')
  }
}