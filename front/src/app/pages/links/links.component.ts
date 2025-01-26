import { Component, inject } from '@angular/core';
import { PaginationService } from '../../services/display/pagination.service';
import { LinkLight } from '../../interfaces/link';
import { LinkService } from '../../services/features/link.service';

@Component({
  selector: 'app-links',
  templateUrl: './links.component.html'
})
export class LinksComponent {
  #linkService = inject(LinkService)
  #paginationService = inject(PaginationService)

  public signal = this.#linkService.linkFlow
  public searchLinks: string = ''
  public elementsPerPage: number = 12
  public editLinksCurrentPage = this.#paginationService.editLinksCurrentPage

  public updateEditLinksCurrentPage(page: number): void {
    this.#paginationService.updateEditLinksCurrentPage(page)
  }

  public filterLinks(): LinkLight[] | undefined {
    return this.signal()?.links.filter(link => link.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  public go(): void {
    if (this.signal()?.link) {
      window.open(this.signal()?.link?.url, '_blank')
    }
  }

  public setLink(link: LinkLight): void {
    this.#linkService.updateLinkId(link.businessId)
  }

  public updateLinkCategoryId(categoryId: number | null): void {
    this.#paginationService.resetEditLinksCurrentPage()
    this.#linkService.updateLinkCategoryId(categoryId)
  }
}