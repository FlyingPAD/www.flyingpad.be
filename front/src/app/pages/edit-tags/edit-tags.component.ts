import { Component, inject } from '@angular/core';
import { TagLight } from '../../interfaces/tag';
import { Router } from '@angular/router';
import { FlowService } from '../../services/flow.service';
import { PaginationService } from '../../services/display/pagination.service';
import { MoodsService } from '../../services/moods.service';

@Component({
  selector: 'app-edit-tags',
  templateUrl: './edit-tags.component.html'
})
export class EditTagsComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  paginationService = inject(PaginationService)
  #moodsService = inject(MoodsService)

  flow = this.#flowService.flow

  searchTags : string = ''
  elementsPerPage : number = 11

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

  filterTags(): TagLight[] | undefined {
    return this.flow()?.tagsByCategory.filter(tag => tag.name.toLowerCase().includes(this.searchTags.toLowerCase()))
  }

  go():void {
    this.#moodsService.updateMoodMenuState('gallery')
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