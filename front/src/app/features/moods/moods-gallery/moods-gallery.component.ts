import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { PaginationService } from '../../../services/display/pagination.service';
import { MoodLight } from '../../../interfaces/mood';
import { MenuService } from '../../../services/display/menu.service';

@Component({
  selector: 'app-moods-gallery',
  templateUrl: './moods-gallery.component.html',
  styleUrl: './moods-gallery.component.scss'
})
export class MoodsGalleryComponent {
  #menuService = inject(MenuService)
  #paginationService = inject(PaginationService)

  @Input() moods: MoodLight[] | undefined = undefined
  @Input() galleryType: string = 'all'
  @Output() moodId = new EventEmitter<number>()

  public environment = environment.apiBaseUrl
  public isRightMenuOn = this.#menuService.isRightMenuOn
  public moodsPerPage: number = 36

  public handleMoodId(moodId: number): void {
    this.moodId.emit(moodId)
  }

  public updateCurrentPage(page: number): void {
    if(this.galleryType === 'all') {
      this.#paginationService.updateMoodsByTagCurrentPage(page)
    }
    if(this.galleryType === 'tag') {
      this.#paginationService.updateMoodsByTagCurrentPage(page)
    }
    if(this.galleryType === 'model') {
      this.#paginationService.updateModelGalleryCurrentPage(page)
    }
    if(this.galleryType === 'artist') {
      this.#paginationService.updateArtistGalleryCurrentPage(page)
    }
    if(this.galleryType === 'franchise') {
      this.#paginationService.updateFranchiseGalleryCurrentPage(page)
    }
  }

  public getCurrentPage(): string | number | undefined {
    if(this.galleryType === 'all') {
      return this.#paginationService.moodsByTagCurrentPage()
    }
    if(this.galleryType === 'tag') {
      return this.#paginationService.moodsByTagCurrentPage()
    }
    if(this.galleryType === 'model') {
      return this.#paginationService.modelGalleryCurrentPage()
    }
    if(this.galleryType === 'artist') {
      return this.#paginationService.artistGalleryCurrentPage()
    }
    if(this.galleryType === 'franchise') {
      return this.#paginationService.franchiseGalleryCurrentPage()
    }
    else return 1
  }
}