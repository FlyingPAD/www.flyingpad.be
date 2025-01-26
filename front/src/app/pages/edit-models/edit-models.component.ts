import { Component, inject } from '@angular/core'
import { FlowService } from '../../services/flow.service'
import { Router } from '@angular/router'
import { ModelLight } from '../../interfaces/model'
import { PaginationService } from '../../services/display/pagination.service'

@Component({
  selector: 'app-edit-models',
  templateUrl: './edit-models.component.html'
})
export class EditModelsComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  #paginationService = inject(PaginationService)

  public flow = this.#flowService.flow
  public searchModels = ''
  public elementsPerPage = 12
  public showList = true
  public showNew = false
  public showEdit = false

  private previousPageNoFilter = 1

  public currentPage() {
    return this.#paginationService.editModelsCurrentPage()
  }

  private triggerReset(): void {
    this.showList = false
    this.showNew = false
    this.showEdit = false
  }
  public triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  public triggerShowNew(): void {
    this.triggerReset()
    this.showNew = true
  }
  public triggerShowEdit(): void {
    this.triggerReset()
    this.showEdit = true
  }

  public onPageChange(newPage: number): void {
    this.#paginationService.updateEditModelsCurrentPage(newPage)
    if (!this.searchModels.trim()) {
      this.previousPageNoFilter = newPage
    }
  }

  public updateCurrentPage(page: number): void {
    this.#paginationService.updateEditModelsCurrentPage(page)
  }

  public filterModels(): ModelLight[] {
    const all = this.flow()?.models ?? []
    return all.filter(m =>
      m.pseudonym.toLowerCase().includes(this.searchModels.toLowerCase())
    )
  }

  public handleSearchModelsChange(newValue: string): void {
    if (!newValue.trim()) {
      this.updateCurrentPage(this.previousPageNoFilter)
    } 
    else {
      this.updateCurrentPage(1)
    }
  }

  public go(): void {
    this.#router.navigateByUrl('/moods')
  }

  public setModel(model: ModelLight): void {
    this.#flowService.updateModelId(model.businessId)
    this.#paginationService.resetModelGalleryCurrentPage()
  }
}