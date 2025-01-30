import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FlowService } from '../../services/flow.service';
import { ButtonTopService } from '../../services/button-top.service';

@Component({
  selector: 'app-media',
  templateUrl: './media.component.html',
  styleUrl: './media.component.scss'
})
export class MediaComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)
  #buttonTopService = inject(ButtonTopService)
  #router = inject(Router)
  
  public flow = this.#flowService.flow

  ngOnInit(): void {
    this.#buttonTopService.setShowButtonTop(true)
  }

  ngOnDestroy(): void {
    this.#buttonTopService.setShowButtonTop(false)
  }
  public updateMediaId(mediaId: number): void {
    this.#flowService.updateMediumId(mediaId)
    this.#router.navigateByUrl('/medium-gallery')
  }
  public updateFranchiseId(franchiseId: number): void {
    this.#flowService.updateFranchiseId(franchiseId)
    this.#router.navigateByUrl('/moods')
  }
  public updateModelId(modelId: number): void {
    this.#flowService.updateModelId(modelId)
    this.#router.navigateByUrl('/moods')
  }
}