import { Component, OnInit, OnDestroy, inject } from '@angular/core';
import { Router } from '@angular/router';
import { FlowService } from '../../services/http/flow.service';
import { ButtonTopService } from '../../services/button-top.service';
import { MoodsService } from '../../services/moods.service';
import { PaginationService } from '../../services/pagination.service';

@Component({
  selector: 'app-media',
  templateUrl: './media.component.html',
  styleUrls: ['./media.component.scss']
})
export class MediaComponent implements OnInit, OnDestroy {
  private flowService = inject(FlowService)
  private moodsService = inject(MoodsService)
  private paginationService = inject(PaginationService)
  private buttonTopService = inject(ButtonTopService)
  private router = inject(Router)

  public flow = this.flowService.flow

  public expandedMedia: Record<number, boolean> = {}
  public expandedFranchises: Record<number, Record<number, boolean>> = {}

  ngOnInit(): void {
    this.buttonTopService.setShowButtonTop(true)

    const currentFlow = this.flow()

    if (currentFlow && currentFlow.medium) {
      const mediaId = currentFlow.medium.businessId

      this.expandedMedia[mediaId] = true

      if (currentFlow.franchise) {
        const franchiseId = currentFlow.franchise.businessId

        this.expandedFranchises[mediaId] = this.expandedFranchises[mediaId] || {}
        this.expandedFranchises[mediaId][franchiseId] = true
      }
    }
  }

  ngOnDestroy(): void {
    this.buttonTopService.setShowButtonTop(false)
  }

  public updateMediaId(mediaId: number): void {
    this.flowService.updateMediumId(mediaId)
  }

  public updateFranchiseId(franchiseId: number): void {
    this.flowService.updateFranchiseId(franchiseId)
  }

  public updateModelId(modelId: number): void {
    this.flowService.updateModelId(modelId)
  }

  public goTo(mode: string, id: number): void {
    if (mode === 'franchise') {
      this.updateFranchiseId(id)
      this.paginationService.resetFranchiseGalleryCurrentPage()
    } 
    else if (mode === 'model') {
      this.updateModelId(id)
      this.paginationService.resetModelGalleryCurrentPage()
    }
    this.moodsService.updateMoodMenuState('gallery')
    this.router.navigateByUrl('/moods')
  }

  public isMediaExpanded(mediaId: number): boolean {
    return !!this.expandedMedia[mediaId]
  }

  public toggleMedia(mediaId: number): void {
    this.updateMediaId(mediaId)
    this.expandedMedia[mediaId] = !this.isMediaExpanded(mediaId)
  }

  public isFranchiseExpanded(mediaId: number, franchiseId: number): boolean {
    return !!this.expandedFranchises[mediaId]?.[franchiseId]
  }

  public toggleFranchise(mediaId: number, franchiseId: number): void {
    this.updateFranchiseId(franchiseId)
    this.expandedFranchises[mediaId] = this.expandedFranchises[mediaId] || {}
    this.expandedFranchises[mediaId][franchiseId] = !this.isFranchiseExpanded(mediaId, franchiseId)
  }
}