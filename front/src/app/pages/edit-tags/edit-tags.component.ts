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
  #paginationService = inject(PaginationService)
  #moodsService = inject(MoodsService)

  public flow = this.#flowService.flow
  public currentPage = this.#paginationService.editTagsCurrentPage
  public searchTags : string = ''
  public elementsPerPage : number = 11
  public showList : boolean = true
  public showNew : boolean = false
  public showNewCategory : boolean = false
  public showEdit : boolean = false
  public showEditCategory : boolean = false

  private triggerReset(): void {
    this.showList = false
    this.showNew = false
    this.showNewCategory = false
    this.showEdit = false
    this.showEditCategory = false
  }
  public triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  public triggerShowNew(): void {
    this.triggerReset()
    this.showNew = true
  }
  public triggerShowNewCategory(): void {
    this.triggerReset()
    this.showNewCategory = true
  }
  public triggerShowEdit(): void {
    this.triggerReset()
    this.showEdit = true
  }
  public triggerShowEditCategory(): void {
    this.triggerReset()
    this.showEditCategory = true
  }

  public updateCurrentPage(page: number): void {
    this.#paginationService.updateEditTagsCurrentPage(page)
  }

  public filterTags(): TagLight[] | undefined {
    return this.flow()?.tagsByCategory.filter(tag => tag.name.toLowerCase().includes(this.searchTags.toLowerCase()))
  }

  public go():void {
    this.#moodsService.updateMoodMenuState('gallery')
    this.#router.navigateByUrl('/moods')
  }

  public setTag(tag : TagLight): void {
    this.#flowService.updateTagId(tag.businessId)
    this.#paginationService.resetMoodsByTagCurrentPage()
  }

  public updateTagCategoryId(tagCategoryId : number | null): void {
    this.#paginationService.resetEditTagsCurrentPage()
    this.#flowService.updateTagCategoryId(tagCategoryId)
  }
}