import { Component, OnInit, inject } from '@angular/core';
import { Router } from '@angular/router';
import { ActiveEntity, GalleryMode } from '../../enumerations/gallery-mode';
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service';
import { GalleryType } from '../../enumerations/gallery-type';
import { FranchiseService } from '../../services/http/franchise.service';
import { ModelService } from '../../services/http/model.service';
import { StateService } from '../../services/custom-state/state.service';

@Component({
  selector: 'app-media',
  templateUrl: './media.component.html',
  styleUrls: ['./media.component.scss']
})
export class MediaComponent implements OnInit {
  #stateService = inject(StateService)
  #franchiseService = inject(FranchiseService)
  #modelService = inject(ModelService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)

  public franchisesFlow = this.#franchiseService.franchisesFlow
  public modelsFlow = this.#modelService.modelsFlow

  public expandedMedia: Record<number, boolean> = {}
  public expandedFranchises: Record<number, Record<number, boolean>> = {}


  ngOnInit(): void {
    this.focusOnSelectedItem()
  }

  public isMediumExpanded(mediumId: number): boolean {
    return !!this.expandedMedia[mediumId]
  }

  public isFranchiseExpanded(mediumId: number, franchiseId: number): boolean {
    return !!this.expandedFranchises[mediumId]?.[franchiseId]
  }

  public toggleMedium(mediumId: number): void {
    this.setMediumId(mediumId)
    this.expandedMedia[mediumId] = !this.isMediumExpanded(mediumId)
  }

  public toggleFranchise(mediumId: number, franchiseId: number): void {
    this.setFranchise(franchiseId)
    this.expandedFranchises[mediumId] = this.expandedFranchises[mediumId] || {}
    this.expandedFranchises[mediumId][franchiseId] = !this.isFranchiseExpanded(mediumId, franchiseId)
  }

  public setMediumId(mediumId: number): void {
    let currentMedium = this.franchisesFlow()?.medium
    if(currentMedium?.businessId != mediumId ) this.#franchiseService.setMediumId(mediumId)
  }

  public setFranchise(franchiseId: number): void {
    let currentFranchise = this.franchisesFlow()?.franchise
    if(currentFranchise?.businessId != franchiseId ) this.#stateService.setFranchiseId(franchiseId)
  }

  public goToFranchise(franchiseId: number): void {
    this.setFranchise(franchiseId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Franchise)
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Franchise)
    this.#router.navigateByUrl('/central-gallery')
  }

  public goToModel(modelId: number): void {
    this.#stateService.setModelId(modelId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Model)
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Model)
    this.#router.navigateByUrl('/central-gallery')
  }

  private focusOnSelectedItem(): void {
    const flow = this.franchisesFlow()
    if (!flow) {
      this.expandedMedia = {}
      this.expandedFranchises = {}
      return
    }
  
    const selectedModel = this.modelsFlow()?.model
    if (selectedModel) {
      let foundMedia: any = null
      let foundFranchise: any = null

      for (const media of flow.mediaList) {
        for (const franchise of media.franchises) {
          if (franchise.models && franchise.models.find((model: any) => model.businessId === selectedModel.businessId)) {
            foundMedia = media
            foundFranchise = franchise
            break
          }
        }
        if (foundMedia && foundFranchise) {
          break
        }
      }
      if (foundMedia && foundFranchise) {
        this.expandedMedia[foundMedia.businessId] = true
        this.expandedFranchises[foundMedia.businessId] = {
          ...(this.expandedFranchises[foundMedia.businessId] || {}),
          [foundFranchise.businessId]: true
        }
        return
      }
    }
  
    const selectedFranchise = flow.franchise
    if (selectedFranchise) {
      let foundMedia: any = null
      for (const media of flow.mediaList) {
        if (media.franchises.find((franchise: any) => franchise.businessId === selectedFranchise.businessId)) {
          foundMedia = media
          break
        }
      }
      if (foundMedia) {
        this.expandedMedia[foundMedia.businessId] = true
        this.expandedFranchises[foundMedia.businessId] = {
          ...(this.expandedFranchises[foundMedia.businessId] || {}),
          [selectedFranchise.businessId ?? -1]: true
        }
        return
      }
    }
  
    const selectedMedium = flow.medium
    if (selectedMedium) {
      this.expandedMedia[selectedMedium.businessId] = true
      return
    }
  
    this.expandedMedia = {}
    this.expandedFranchises = {}
  }
}