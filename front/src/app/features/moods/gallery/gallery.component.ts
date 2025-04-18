import { Component, EventEmitter, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { DetailedMood, MoodLight } from '../../../interfaces/mood';
import { MenuService } from '../../../services/user-interface/menu.service';
import { Observable, Subject, takeUntil } from 'rxjs';
import { MoodsGalleryService } from '../../../services/user-interface/moods-gallery.service';
import { GalleryType } from '../../../enumerations/gallery-type';
import { PaginationService } from '../../../services/user-interface/pagination.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrl: './gallery.component.scss'
})
export class GalleryComponent implements OnInit, OnDestroy {
  #menuService = inject(MenuService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #paginationService = inject(PaginationService)

  @Input() moods: MoodLight[] | undefined
  @Input() currentMood: DetailedMood | undefined
  @Input() resetPaginationSignal!: Observable<void>

  @Output() setMood = new EventEmitter<number>()

  private destroy$ = new Subject<void>()

  public galleryType = this.#moodsGalleryService.galleryType
  public galleryTypes = GalleryType

  public moodSizeToggle = this.#moodsGalleryService.moodSizeToggle
  public isRightMenuOn = this.#menuService.isRightMenuOn

  public environment = environment.apiBaseUrl

  public itemsPerPage: number = this.#paginationService.ITEMS_PER_PAGE
  public currentPage = this.#paginationService.galleryCurrentPage


  ngOnInit(): void {
    if (this.resetPaginationSignal) {
      this.resetPaginationSignal
        .pipe(takeUntil(this.destroy$))
        .subscribe(() => this.resetPagination())
    }
  }

  ngOnDestroy(): void {
    this.destroy$.next()
    this.destroy$.complete()
  }

  private resetPagination(): void {
    this.#paginationService.resetGalleryCurrentPage()
  }

  public setCurrentPage(page: number): void {
    this.#paginationService.setGalleryCurrentPage(page) 
  }
  public handleSetMood(moodId: number): void {
    this.setMood.emit(moodId)
  }
}