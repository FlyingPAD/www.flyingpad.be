import { Component, inject } from '@angular/core';
import { LinkLight } from '../../interfaces/link';
import { FlowService } from '../../services/flow.service';
import { PaginationService } from '../../services/display/pagination.service';

@Component({
  selector: 'app-edit-links',
  templateUrl: './edit-links.component.html'
})
export class EditLinksComponent {
  #flowService = inject(FlowService)
  #paginationService = inject(PaginationService)

  public flow = this.#flowService.flow
  public currentPage = this.#paginationService.editLinksCurrentPage
  public searchLinks : string = ''
  public elementsPerPage : number = 12
  public showList : boolean = true
  public showNew : boolean = false
  public showNewCategory : boolean = false
  public showEdit : boolean = false
  public showEditCategory : boolean = false

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
    this.#paginationService.updateEditLinksCurrentPage(page)
  }

  public filterLinks(): LinkLight[] | undefined {
    return this.flow()?.linksByCategory.filter(link => link.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  public go(): void {
    if(this.flow()?.link) {
      window.open(this.flow()?.link?.url, '_blank')
    }
  }

  public setLink(link : LinkLight): void {
    this.#flowService.updateLinkId(link.businessId)
  }

  public updateLinkCategoryId(categoryId : number | null): void {
    this.#paginationService.resetEditLinksCurrentPage()
    this.#flowService.updateLinkCategoryId(categoryId)
  }
}