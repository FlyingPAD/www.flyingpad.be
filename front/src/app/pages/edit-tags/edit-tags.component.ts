import { Component, inject, OnInit } from '@angular/core';
import { TagLight } from '../../interfaces/tag';
import { Router } from '@angular/router';
import { TagService } from '../../services/http/tag.service';
import { MoodsGalleryService } from '../../services/moods-gallery.service';
import { StorageService } from '../../services/storage.service';
import { EditTagsViewMode } from '../../enumerations/view-modes-edition';
import { GalleryType } from '../../enumerations/gallery-type';
import { StateService } from '../../services/custom-state/state.service';
import { GalleryMode } from '../../enumerations/gallery-mode';

@Component({
  selector: 'app-edit-tags',
  templateUrl: './edit-tags.component.html'
})
export class EditTagsComponent implements OnInit {
  #stateService = inject(StateService)
  #tagService = inject(TagService)
  #storageService = inject(StorageService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)

  public tagsFlow = this.#tagService.tagsFlow

  public currentPage = 1
  public elementsPerPage: number = 12
  public searchTags: string = ''

  public viewModes = EditTagsViewMode
  public currentViewMode = EditTagsViewMode.ListView


  ngOnInit(): void {
    let storedPage = this.#storageService.getItem('pageTags')
    if (storedPage != null) this.setCurrentPage(storedPage as number)
  }

  public setCurrentPage(page: number): void {
    this.currentPage = page
    this.#storageService.setItem('pageTags', page)
  }

  public setViewMode(viewMode: EditTagsViewMode) {
    this.currentViewMode = viewMode
  }

  public filterTags(): TagLight[] | undefined {
    return this.tagsFlow()?.tagsByCategory.filter(tag => tag.name.toLowerCase().includes(this.searchTags.toLowerCase()))
  }

  public goToTag(): void {
    this.#stateService.setTagId(this.tagsFlow()?.tag?.businessId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Tag)
    this.#router.navigateByUrl('/central-gallery')
  }

  public goToTagCategory(): void {
    this.#stateService.setTagCategoryId(this.tagsFlow()?.tagCategory?.businessId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.TagCategory)
    this.#router.navigateByUrl('/central-gallery')
  }

  public setTagId(tagId: number | undefined): void {
    this.#stateService.setTagId(tagId)
  }

  public setTagCategoryId(tagCategoryId: number | undefined): void {
    this.setCurrentPage(1)
    this.setViewMode(EditTagsViewMode.ListView)
    this.#tagService.setTagCategoryId(tagCategoryId)
  }
}