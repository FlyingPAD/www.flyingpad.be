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
  elementsPerPage : number = 15

  showList : boolean = true
  showNewTag : boolean = false
  showNewCategory : boolean = false
  showEditTag : boolean = false
  showEditCategory : boolean = false

  triggerReset(): void {
    this.showList = false
    this.showNewTag = false
    this.showNewCategory = false
    this.showEditTag = false
    this.showEditCategory = false
  }
  triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  triggerShowNewTag(): void {
    this.triggerReset()
    this.showNewTag = true
  }
  triggerShowNewCategory(): void {
    this.triggerReset()
    this.showNewCategory = true
  }
  triggerShowEditTag(): void {
    this.triggerReset()
    this.showEditTag = true
  }
  triggerShowEditCategory(): void {
    this.triggerReset()
    this.showEditCategory = true
  }

  filterTags(): TagLight[] | undefined {
    return this.flow()?.tagsByCategory.filter(tag => tag.name.toLowerCase().includes(this.searchTags.toLowerCase()))
  }

  go():void {
    this.#router.navigateByUrl('/moods')
  }

  setTag(tag : TagLight): void {

    this.#flowService.updateTagId(tag.businessId)
  }

  updateTagCategoryId(tagCategoryId : number | null): void {
    this.paginationService.editTagsCurrentPageReset()
    this.#flowService.updateTagCategoryId(tagCategoryId)
  }
}