import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { Router } from '@angular/router';
import { PaginationService } from '../../services/pagination.service';
import { FranchiseLight } from '../../models/franchise';

@Component({
  selector: 'app-edit-franchises',
  templateUrl: './edit-franchises.component.html',
  styleUrl: './edit-franchises.component.scss'
})
export class EditFranchisesComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  paginationService = inject(PaginationService)

  flow = this.#flowService.flow

  currentFranchise : FranchiseLight | undefined = this.flow()?.franchise
  searchFranchises : string = ''
  elementsPerPage : number = 15

  showList : boolean = true
  showNew : boolean = false
  showNewCategory : boolean = false
  showEdit : boolean = false
  showEditCategory : boolean = false

  triggerReset(): void {
    this.showList = false
    this.showNew = false
    this.showNewCategory = false
    this.showEdit = false
    this.showEditCategory = false
  }
  triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  triggerShowNew(): void {
    this.triggerReset()
    this.showNew = true
  }
  triggerShowNewCategory(): void {
    this.triggerReset()
    this.showNewCategory = true
  }
  triggerShowEdit(): void {
    this.triggerReset()
    this.showEdit = true
  }
  triggerShowEditCategory(): void {
    this.triggerReset()
    this.showEditCategory = true
  }

  filterFranchises(): FranchiseLight[] | undefined {
    return this.flow()?.franchisesByMedia.filter(franchise => franchise.name.toLowerCase().includes(this.searchFranchises.toLowerCase()))
  }

  go():void {
    this.#flowService.updateMoodsGalleryType('franchise')
    this.#router.navigateByUrl('/moods')
  }

  setFranchise(franchise : FranchiseLight): void {
    this.currentFranchise = franchise
    this.#flowService.updateFranchiseId(franchise.businessId)
  }

  updateMediaId(mediaId : number | null): void {
    this.#flowService.updateMediaId(mediaId)
  }
}