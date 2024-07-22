import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';

@Component({
  selector: 'app-links',
  templateUrl: './links.component.html',
  styleUrl: './links.component.scss'
})
export class LinksComponent {
  #flowService = inject(FlowService)

  flow = this.#flowService.flow

  elementsPerPage : number = 17
  currentPage : number = 1
  showDialog : boolean = false
  showFormDialog : boolean = false

  searchLinks : string = ''
  filterLinks() {
    return this.flow()?.linksByCategory.filter(m => m.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }
  updateLinkCategoryId(linkCategoryId: number | null): void {
    this.#flowService.updateLinkCategoryId(linkCategoryId)
    this.pageReset()
  }
  updateLinkId(linkId: number): void {
    this.#flowService.updateLinkId(linkId)
  }
  handleFormDialog() {
    this.showFormDialog = false
  }
  openFormDialog() {
    this.showFormDialog = !this.showFormDialog
  }
  handleDialog() {
    this.showDialog = false
  }
  openDialog() {
    this.showDialog = !this.showDialog
  }
  pageReset() {
    this.currentPage = 1
  }
}