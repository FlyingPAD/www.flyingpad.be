import { Component, inject, OnInit } from '@angular/core';
import { LinkLight } from '../../interfaces/link';
import { LinkService } from '../../services/http/link.service';
import { EditLinksViewMode } from '../../enumerations/view-modes-edition';
import { StorageService } from '../../services/storage.service';

@Component({
  selector: 'app-edit-links',
  templateUrl: './edit-links.component.html'
})

export class EditLinksComponent implements OnInit {
  #linkService = inject(LinkService)
  #storageService = inject(StorageService)

  public linksFlow = this.#linkService.linksFlow

  public currentPage = 1
  public elementsPerPage: number = 12
  public searchLinks: string = ''

  public viewModes = EditLinksViewMode
  public currentViewMode = EditLinksViewMode.ListView


  ngOnInit(): void {
    let storedPage = this.#storageService.getItem('pageLinks')
    if (storedPage != null) this.setCurrentPage(storedPage as number)
  }

  public setCurrentPage(page: number): void {
    this.currentPage = page
    this.#storageService.setItem('pageLinks', page)
  }

  public setViewMode(viewMode: EditLinksViewMode) {
    this.currentViewMode = viewMode
  }

  public filterLinks(): LinkLight[] | undefined {
    return this.linksFlow()?.linksByCategory.filter(link => link.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  public go(): void {
    window.open(this.linksFlow()?.link?.url, '_blank')
  }

  public setLinkId(linkId: number | undefined): void {
    this.#linkService.setLinkId(linkId)
  }

  public setLinkCategoryId(linkCategoryId: number | undefined): void {
    this.setCurrentPage(1)
    this.setViewMode(EditLinksViewMode.ListView)
    this.#linkService.setLinkCategoryId(linkCategoryId)
  }
}