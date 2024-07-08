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

  searchLinks : string = ''
  filterLinks() {
    return this.flow()?.linksByCategory.filter(m => m.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  updateLinkCategoryId(linkCategoryId: number | null): void {
    this.#flowService.updateLinkCategoryId(linkCategoryId)
  }
}