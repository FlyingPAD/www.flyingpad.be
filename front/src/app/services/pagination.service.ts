import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PaginationService {
  #fullGalleryCurrentPage = new BehaviorSubject<number>(1)
  #artistGalleryCurrentPage = new BehaviorSubject<number>(1)
  #editArtistsCurrentPage = new BehaviorSubject<number>(1)
  #franchiseGalleryCurrentPage = new BehaviorSubject<number>(1)
  #editFranchisesCurrentPage = new BehaviorSubject<number>(1)
  #modelGalleryCurrentPage = new BehaviorSubject<number>(1)
  #editModelsCurrentPage = new BehaviorSubject<number>(1)
  #editTagsCurrentPage = new BehaviorSubject<number>(1)
  #editLinksCurrentPage = new BehaviorSubject<number>(1)
  #moodsByTagCurrentPage = new BehaviorSubject<number>(1)
  #moodsByTagCategoryCurrentPage = new BehaviorSubject<number>(1)

  // SIGNALS
  public fullGalleryCurrentPage = toSignal(this.#fullGalleryCurrentPage) as Signal<number>
  public artistGalleryCurrentPage = toSignal(this.#artistGalleryCurrentPage) as Signal<number>
  public editArtistsCurrentPage = toSignal(this.#editArtistsCurrentPage) as Signal<number>
  public franchiseGalleryCurrentPage = toSignal(this.#franchiseGalleryCurrentPage) as Signal<number>
  public editFranchisesCurrentPage = toSignal(this.#editFranchisesCurrentPage) as Signal<number>
  public modelGalleryCurrentPage = toSignal(this.#modelGalleryCurrentPage) as Signal<number>
  public editModelsCurrentPage = toSignal(this.#editModelsCurrentPage) as Signal<number>
  public editTagsCurrentPage = toSignal(this.#editTagsCurrentPage) as Signal<number>
  public editLinksCurrentPage = toSignal(this.#editLinksCurrentPage) as Signal<number>
  public moodsByTagCurrentPage = toSignal(this.#moodsByTagCurrentPage) as Signal<number>
  public moodsByTagCategoryCurrentPage = toSignal(this.#moodsByTagCategoryCurrentPage) as Signal<number>

  // UPDATE PAGE METHODS
  public updateFullGalleryCurrentPage(page: number): void {
    this.#fullGalleryCurrentPage.next(page)
  }
  public updateArtistGalleryCurrentPage(page: number): void {
    this.#artistGalleryCurrentPage.next(page)
  }
  public updateEditArtistsCurrentPage(page: number): void {
    this.#editArtistsCurrentPage.next(page)
  }
  public updateFranchiseGalleryCurrentPage(page: number): void {
    this.#franchiseGalleryCurrentPage.next(page)
  }
  public updateEditFranchisesCurrentPage(page: number): void {
    this.#editFranchisesCurrentPage.next(page)
  }
  public updateModelGalleryCurrentPage(page: number): void {
    this.#modelGalleryCurrentPage.next(page)
  }
  public updateEditModelsCurrentPage(page: number): void {
    this.#editModelsCurrentPage.next(page)
  }
  public updateEditTagsCurrentPage(page: number): void {
    this.#editTagsCurrentPage.next(page)
  }
  public updateEditLinksCurrentPage(page: number): void {
    this.#editLinksCurrentPage.next(page)
  }
  public updateMoodsByTagCurrentPage(page: number): void {
    this.#moodsByTagCurrentPage.next(page)
  }
  public updateMoodsByTagCategoryCurrentPage(page: number): void {
    this.#moodsByTagCategoryCurrentPage.next(page)
  }

  // RESET PAGE METHODS
  public resetFullGalleryCurrentPage(): void {
    this.updateFullGalleryCurrentPage(1)
  }
  public resetArtistGalleryCurrentPage(): void {
    this.updateArtistGalleryCurrentPage(1)
  }
  public resetEditArtistsCurrentPage(): void {
    this.updateEditArtistsCurrentPage(1)
  }
  public resetFranchiseGalleryCurrentPage(): void {
    this.updateFranchiseGalleryCurrentPage(1)
  }
  public resetEditFranchisesCurrentPage(): void {
    this.updateEditFranchisesCurrentPage(1)
  }
  public resetModelGalleryCurrentPage(): void {
    this.updateModelGalleryCurrentPage(1)
  }
  public resetEditModelsCurrentPage(): void {
    this.updateEditModelsCurrentPage(1)
  }
  public resetEditTagsCurrentPage(): void {
    this.updateEditTagsCurrentPage(1)
  }
  public resetEditLinksCurrentPage(): void {
    this.updateEditLinksCurrentPage(1)
  }
  public resetMoodsByTagCurrentPage(): void {
    this.updateMoodsByTagCurrentPage(1)
  }
  public resetMoodsByTagCategoryCurrentPage(): void {
    this.updateMoodsByTagCategoryCurrentPage(1)
  }
}