import { Component, inject } from '@angular/core';
import { LinkLight } from '../../models/link';
import { FlowService } from '../../services/flow.service';
import { PaginationService } from '../../services/pagination.service';

@Component({
  selector: 'app-edit-links',
  templateUrl: './edit-links.component.html',
  styleUrl: './edit-links.component.scss'
})
export class EditLinksComponent {
  #flowService = inject(FlowService)
  paginationService = inject(PaginationService)

  flow = this.#flowService.flow

  currentLink : LinkLight | undefined = this.flow()?.link
  searchLinks : string = ''
  elementsPerPage : number = 18

  showList : boolean = true
  showNew : boolean = false
  showEdit : boolean = false

  triggerReset(): void {
    this.showList = false
    this.showNew = false
    this.showEdit = false
  }
  triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  triggerShowNew(): void {
    this.triggerReset()
    this.showNew = true
  }
  triggerShowEdit(): void {
    this.triggerReset()
    this.showEdit = true
  }

  filterLinks(): LinkLight[] | undefined {
    return this.flow()?.linksByCategory.filter(link => link.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  go(): void {
    if(this.currentLink) {
      window.open(this.currentLink.url, '_blank')
    }
  }

  setLink(link : LinkLight): void {
    this.currentLink = link
    this.#flowService.updateLinkId(link.businessId)
  }

  updateLinkCategoryId(categoryId : number | null): void {
      this.#flowService.updateLinkCategoryId(categoryId)
  }
}