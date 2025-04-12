import { Component, inject, OnInit } from '@angular/core';
import { LinkLight } from '../../interfaces/link';
import { LinkService } from '../../services/http/link.service';
import { StorageService } from '../../services/storage.service';

@Component({
  selector: 'app-links',
  templateUrl: './links.component.html'
})
export class LinksComponent implements OnInit {
  #linkService = inject(LinkService)
  #storageService = inject(StorageService)

  public linksFlow = this.#linkService.linksFlow

  public currentPage = 1
  public searchLinks: string = ''
  public elementsPerPage: number = 12


  ngOnInit(): void {
    let storedPage = this.#storageService.getItem('pageLinks')
    if(storedPage != null) this.setCurrentPage(storedPage as number)
  }

  private resetCurrentPage(): void {
    this.currentPage = 1
    this.#storageService.setItem('pageLinks', this.currentPage)
  }

  public setCurrentPage(page: number): void {
    this.currentPage = page
    this.#storageService.setItem('pageLinks', page)
  }

  public setLinkCategoryId(linkCategoryId: number | undefined): void {
    this.resetCurrentPage()
    if (this.linksFlow()?.linkCategory?.businessId === linkCategoryId) return
    this.#linkService.setLinkCategoryId(linkCategoryId)
  }

  public setLinkId(linkId: number | undefined): void {
    if (this.linksFlow()?.link?.businessId === linkId) return
    this.#linkService.setLinkId(linkId)
  }

  public filterLinks(): LinkLight[] | undefined {
    return this.linksFlow()?.linksByCategory.filter(link => link.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }
  
  public go(): void {
    window.open(this.linksFlow()?.link?.url, '_blank')
  }
}