import { Component, inject } from '@angular/core';
import { TagLight } from '../../models/tag';
import { Router } from '@angular/router';
import { FlowService } from '../../services/flow.service';
import { PaginationService } from '../../services/pagination.service';

@Component({
  selector: 'app-edit-tags',
  templateUrl: './edit-tags.component.html',
  styleUrl: './edit-tags.component.scss'
})
export class EditTagsComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  paginationService = inject(PaginationService)

  flow = this.#flowService.flow

  searchTags : string = ''
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

  filterTags(): TagLight[] | undefined {
    return this.flow()?.tagsByCategory.filter(tag => tag.name.toLowerCase().includes(this.searchTags.toLowerCase()))
  }

  go():void {
    this.#flowService.updateMoodsGalleryType('tag')
    this.#router.navigateByUrl('/moods')
  }

  setTag(tag : TagLight): void {
    this.#flowService.updateTagId(tag.businessId)
  }

  updateTagCategoryId( tagCategoryId : number | null): void {
    this.paginationService.editTagsCurrentPageReset()
    this.#flowService.updateTagCategoryId(tagCategoryId)
  }
}