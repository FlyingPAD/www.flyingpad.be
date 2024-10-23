import { Component, inject } from '@angular/core';
import { LinkLight } from '../../interfaces/link';
import { FlowService } from '../../services/flow.service';
import { PaginationService } from '../../services/display/pagination.service';
import { ImageUrlService } from '../../services/display/image-url.service';

@Component({
  selector: 'app-edit-links',
  templateUrl: './edit-links.component.html',
  styleUrl: './edit-links.component.scss'
})
export class EditLinksComponent {
  #flowService = inject(FlowService)
  paginationService = inject(PaginationService)
  #imageURLService = inject(ImageUrlService)

  flow = this.#flowService.flow

  searchLinks : string = ''
  elementsPerPage : number = 12

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

  public getImageUrl(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}