import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { Router } from '@angular/router';
import { PaginationService } from '../../services/display/pagination.service';
import { FranchiseLight } from '../../interfaces/franchise';

@Component({
  selector: 'app-edit-franchises',
  templateUrl: './edit-franchises.component.html'
})
export class EditFranchisesComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  #paginationService = inject(PaginationService)

  public flow = this.#flowService.flow
  public currentPage = this.#paginationService.editFranchisesCurrentPage
  public searchFranchises: string = ''
  public elementsPerPage: number = 12
  public showList: boolean = true
  public showNew: boolean = false
  public showNewCategory: boolean = false
  public showEdit: boolean = false
  public showEditCategory: boolean = false

  private triggerReset(): void {
    this.showList = false
    this.showNew = false
    this.showNewCategory = false
    this.showEdit = false
    this.showEditCategory = false
  }
  public triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  public triggerShowNew(): void {
    this.triggerReset()
    this.showNew = true
  }
  public triggerShowNewCategory(): void {
    this.triggerReset()
    this.showNewCategory = true
  }
  public triggerShowEdit(): void {
    this.triggerReset()
    this.showEdit = true
  }
  public triggerShowEditCategory(): void {
    this.triggerReset()
    this.showEditCategory = true
  }

  public updateCurrentPage(page: number): void {
    this.#paginationService.updateEditFranchisesCurrentPage(page)
  }


  public filterFranchises(): FranchiseLight[] | undefined {
    return this.flow()?.franchisesByMedium.filter(franchise => franchise.name.toLowerCase().includes(this.searchFranchises.toLowerCase()))
  }

  public go(): void {
    this.#router.navigateByUrl('/moods')
  }

  public setFranchise(franchise: FranchiseLight): void {
    this.#flowService.updateFranchiseId(franchise.businessId)
    this.#paginationService.resetFranchiseGalleryCurrentPage()
  }

  public updateMediaId(mediaId: number | null): void {
    this.#paginationService.resetEditFranchisesCurrentPage()
    this.#flowService.updateMediumId(mediaId)
  }
}