import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { ButtonTopService } from '../../services/user-interface/button-top.service';
import { TagService } from '../../services/http/tag.service';
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service';
import { GalleryType } from '../../enumerations/gallery-type';
import { StateService } from '../../services/custom-state/state.service';
import { Router } from '@angular/router';
import { GalleryMode } from '../../enumerations/gallery-mode';

@Component({
  selector: 'app-tags',
  templateUrl: './tags.component.html',
  styleUrls: ['./tags.component.scss']
})
export class TagsComponent implements OnInit, OnDestroy {
  #stateService = inject(StateService)
  #tagService = inject(TagService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #buttonTopService = inject(ButtonTopService)
  #router = inject(Router)

  public tagsFlow = this.#tagService.tagsFlow
  public expandedCategories: Record<number, boolean> = {}


  ngOnInit(): void {
    window.scrollTo(0, 0)
    this.#buttonTopService.setShowButtonTop(true)

    const currentFlow = this.tagsFlow()

    if (currentFlow && currentFlow.tagCategory) {
      const categoryId = currentFlow.tagCategory.businessId
      this.expandedCategories[categoryId] = true
    }
  }

  ngOnDestroy(): void {
    this.#buttonTopService.setShowButtonTop(false)
  }

  public isCategoryExpanded(categoryId: number): boolean {
    return !!this.expandedCategories[categoryId]
  }

  public toggleCategory(categoryId: number): void {
    this.setTagCategoryId(categoryId)
    this.expandedCategories[categoryId] = !this.isCategoryExpanded(categoryId)
  }

  public setTagCategoryId(tagCategoryId: number): void {
    if(this.tagsFlow()?.tagCategory?.businessId != tagCategoryId) this.#tagService.setTagCategoryId(tagCategoryId)
  }

  public setTagId(tagId: number): void {
    if(this.tagsFlow()?.tag?.businessId != tagId) this.#stateService.setTagId(tagId)
  }

  public goToTag(tagId: number): void {
    this.setTagId(tagId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Tag)
    this.#router.navigateByUrl('/central-gallery')
  }
}