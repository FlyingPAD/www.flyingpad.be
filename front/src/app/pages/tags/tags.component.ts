import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { ButtonTopService } from '../../services/button-top.service';
import { MoodsService } from '../../services/moods.service';
import { PaginationService } from '../../services/pagination.service';

@Component({
  selector: 'app-tags',
  templateUrl: './tags.component.html',
  styleUrls: ['./tags.component.scss']
})
export class TagsComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)
  #buttonTopService = inject(ButtonTopService)
  #moodsService = inject(MoodsService)
  #paginationService = inject(PaginationService)

  public flow = this.#flowService.flow
  public expandedCategories: Record<number, boolean> = {}

  ngOnInit(): void {
    window.scrollTo(0, 0)
    this.#buttonTopService.setShowButtonTop(true)

    const currentFlow = this.flow()

    if (currentFlow && currentFlow.tagCategory) {
      const categoryId = currentFlow.tagCategory.businessId
      this.expandedCategories[categoryId] = true
    }
  }

  ngOnDestroy(): void {
    this.#buttonTopService.setShowButtonTop(false)
  }

  public updateTagCategoryId(categoryId: number): void {
    this.#flowService.updateTagCategoryId(categoryId)
  }

  public updateTagId(tagId: number | null): void {
    this.#flowService.updateTagId(tagId)
    this.#paginationService.resetMoodsByTagCurrentPage()
    this.#moodsService.updateMoodMenuState('gallery')
  }

  public isCategoryExpanded(categoryId: number): boolean {
    return !!this.expandedCategories[categoryId]
  }

  public toggleCategory(categoryId: number): void {
    this.updateTagCategoryId(categoryId)
    this.expandedCategories[categoryId] = !this.isCategoryExpanded(categoryId)
  }
}