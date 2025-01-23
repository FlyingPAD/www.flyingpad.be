import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { PaginationService } from '../../services/display/pagination.service';
import { LinkLight } from '../../interfaces/link';
import { LinkService } from '../../services/features/link.service';

@Component({
  selector: 'app-links',
  templateUrl: './links.component.html'
})
export class LinksComponent {
  #linkService = inject(LinkService)
  paginationService = inject(PaginationService)

  signal = this.#linkService.linkFlow

  searchLinks : string = ''
  elementsPerPage : number = 12


  filterLinks(): LinkLight[] | undefined {
    return this.signal()?.links.filter(link => link.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  go(): void {
    if(this.signal()?.link) {
      window.open(this.signal()?.link?.url, '_blank')
    }
  }

  setLink(link : LinkLight): void {
    this.#linkService.updateLinkId(link.businessId)
  }

  updateLinkCategoryId(categoryId : number | null): void {
    this.paginationService.editLinksCurrentPageReset()
    this.#linkService.updateLinkCategoryId(categoryId)
  }
}