import { Component, inject, OnInit } from '@angular/core';
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
export class TagsComponent implements OnInit {
  #stateService = inject(StateService)
  #tagService = inject(TagService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)

  public tagsFlow = this.#tagService.tagsFlow
  public expandedCategories: Record<number, boolean> = {}


  ngOnInit(): void {
    window.scrollTo(0, 0)

    const currentFlow = this.tagsFlow()

    if (currentFlow && currentFlow.tagCategory) {
      const categoryId = currentFlow.tagCategory.businessId
      this.expandedCategories[categoryId] = true
    }
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

  public goToCategory(categoryId: number): void {
    this.setTagCategoryId(categoryId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.TagCategory)
    this.#router.navigateByUrl('/central-gallery')
  }
}