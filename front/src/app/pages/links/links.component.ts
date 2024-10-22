import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { PaginationService } from '../../services/pagination.service';
import { LinkLight } from '../../interfaces/link';

@Component({
  selector: 'app-links',
  templateUrl: './links.component.html',
  styleUrl: './links.component.scss'
})
export class LinksComponent {
  #flowService = inject(FlowService)
  paginationService = inject(PaginationService)

  flow = this.#flowService.flow

  searchLinks : string = ''
  elementsPerPage : number = 12


  filterLinks(): LinkLight[] | undefined {
    return this.flow()?.linksByCategory.filter(link => link.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  go(): void {
    if(this.flow()?.link) {
      window.open(this.flow()?.link?.url, '_blank')
    }
  }

  setLink(link : LinkLight): void {
    this.#flowService.updateLinkId(link.businessId)
  }

  updateLinkCategoryId(categoryId : number | null): void {
    this.paginationService.editLinksCurrentPageReset()
    this.#flowService.updateLinkCategoryId(categoryId)
  }
}