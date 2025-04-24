import { Component, EventEmitter, inject, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { DetailedMood, MoodLight } from '../../../interfaces/mood';
import { MenuService } from '../../../services/user-interface/menu.service';
import { Observable, Subject, takeUntil } from 'rxjs';
import { MoodsGalleryService } from '../../../services/user-interface/moods-gallery.service';
import { GalleryType } from '../../../enumerations/gallery-type';
import { PaginationService } from '../../../services/user-interface/pagination.service';
import { VideoYouTube } from '../../../interfaces/mood-video-youtube';
import { Video } from '../../../interfaces/mood-video';
import { Image } from '../../../interfaces/mood-image';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrl: './gallery.component.scss'
})
export class GalleryComponent implements OnInit, OnChanges, OnDestroy {
  #menuService = inject(MenuService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #paginationService = inject(PaginationService)
  #sanitizer = inject(DomSanitizer)

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

  public safeYouTubeUrl: SafeResourceUrl | null = null
  public safeSoundCloudUrl: SafeResourceUrl | null = null


  ngOnInit(): void {
    if (this.resetPaginationSignal) {
      this.resetPaginationSignal
        .pipe(takeUntil(this.destroy$))
        .subscribe(() => this.resetPagination())
    }

    this.updateSafeSoundCloudUrl()
    this.updateSafeYoutubeUrl()
  }

  ngOnChanges(changes: SimpleChanges): void {
    this.updateSafeSoundCloudUrl()
    this.updateSafeYoutubeUrl()
  }

  ngOnDestroy(): void {
    this.destroy$.next()
    this.destroy$.complete()
  }

  private updateSafeYoutubeUrl(): void {
    const url = this.typeCheck(this.currentMood)?.url
    if (!url) {
      this.safeYouTubeUrl = null
      return;
    }

    this.safeYouTubeUrl = this.#sanitizer.bypassSecurityTrustResourceUrl(
      `https://www.youtube.com/embed/${url}`
    )
  }

  private updateSafeSoundCloudUrl(): void {
    // currentMood vient de DetailedMood, qui a embedUrl pour type 5
    if (this.currentMood?.type === 5 && this.currentMood.embedUrl) {
      this.safeSoundCloudUrl = this.#sanitizer.bypassSecurityTrustResourceUrl(
        this.currentMood.embedUrl
      )
    } else {
      this.safeSoundCloudUrl = null
    }
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

  public typeCheck(media: any) {
    if (this.currentMood?.type === 1) {
      return media as Image
    }
    if (this.currentMood?.type === 2) {
      return media as Video
    }
    if (this.currentMood?.type === 4) {
      return media as VideoYouTube
    }
    else {
      return media
    }
  }
}