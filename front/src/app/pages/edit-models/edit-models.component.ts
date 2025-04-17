import { Component, computed, signal, inject, OnInit } from '@angular/core'
import { Router } from '@angular/router'
import { ModelLight } from '../../interfaces/model'
import { ModelService } from '../../services/http/model.service'
import { FranchiseService } from '../../services/http/franchise.service'
import { StateService } from '../../services/custom-state/state.service'
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service'
import { GalleryType } from '../../enumerations/gallery-type'
import { EditModelsViewMode } from '../../enumerations/view-modes-edition'
import { ActiveEntity, GalleryMode } from '../../enumerations/gallery-mode'
import { StorageService } from '../../services/storage.service'
import { StorageProperties } from '../../enumerations/storage-properties'

@Component({
  selector: 'app-edit-models',
  templateUrl: './edit-models.component.html'
})
export class EditModelsComponent implements OnInit {
  private storageService = inject(StorageService)
  private stateService = inject(StateService)
  private modelService = inject(ModelService)
  private franchiseService = inject(FranchiseService)
  private router = inject(Router)
  private moodsGalleryService = inject(MoodsGalleryService)

  public modelsFlow = this.modelService.modelsFlow
  public franchisesFlow = this.franchiseService.franchisesFlow

  public currentViewMode = EditModelsViewMode.ListView
  public viewModes = EditModelsViewMode

  public searchModelsSignal = signal('')
  public manualPage = signal(1)
  public manualPageSet = signal(false)
  public elementsPerPage = 12

  public displayPage = computed((): number => {
    const models = this.modelsFlow()?.models ?? []
    return this.calculateCurrentPage(models)
  })

  ngOnInit(): void {
    const models = this.modelsFlow()?.models ?? []
    if (models.length > 0) {
      const storedModelId = this.storageService.getItem(StorageProperties.StateModelId)
      if (storedModelId) {
        const index = models.findIndex(m => m.businessId === storedModelId)
        if (index !== -1) {
          this.manualPage.set(Math.floor(index / this.elementsPerPage) + 1)
        }
      }
    }
  }

  private calculateCurrentPage(models: ModelLight[]): number {
    if (models.length === 0) {
      return 1
    }
    const filter = this.searchModelsSignal()
    if (filter) {
      const filteredModels = models.filter(m =>
        m.pseudonym.toLowerCase().includes(filter.toLowerCase())
      )
      const selectedModelId = this.modelsFlow()?.model?.businessId
      const selectedIndex = filteredModels.findIndex(m => m.businessId === selectedModelId)
      if (selectedModelId && selectedIndex !== -1) {
        return Math.floor(selectedIndex / this.elementsPerPage) + 1
      }
      return 1
    } else {
      if (this.manualPageSet()) {
        return this.manualPage()
      } else {
        const storedModelId = this.storageService.getItem(StorageProperties.StateModelId)
        if (storedModelId) {
          const index = models.findIndex(m => m.businessId === storedModelId)
          if (index !== -1) {
            return Math.floor(index / this.elementsPerPage) + 1
          }
        }
        return this.manualPage()
      }
    }
  }

  public filterModels(): ModelLight[] {
    const models = this.modelsFlow()?.models ?? []
    
    return models.filter(m =>
      m.pseudonym.toLowerCase().includes(this.searchModelsSignal().toLowerCase())
    )
  }

  public onPageChange(newPage: number): void {
    this.manualPage.set(newPage)
    this.manualPageSet.set(true)
  }

  public handleSearchModelsChange(newValue: string): void {
    this.searchModelsSignal.set(newValue)
    if (!newValue.trim()) {
      this.manualPageSet.set(false)
    }
  }

  public setViewMode(viewMode: EditModelsViewMode): void {
    this.currentViewMode = viewMode
  }

  public setModelId(modelId: number): void {
    this.stateService.setModelId(modelId)
  }

  public go(): void {
    this.stateService.setModelId(this.modelsFlow()?.model?.businessId)
    this.moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.moodsGalleryService.setGalleryMode(GalleryMode.Model)
    this.moodsGalleryService.setActiveEntity(ActiveEntity.Model)
    this.router.navigateByUrl('/central-gallery')
  }
}