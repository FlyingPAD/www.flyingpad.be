import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PaginationService {
  public readonly ITEMS_PER_PAGE: number = 36
  
  #galleryCurrentPage$ = new BehaviorSubject<number>(1)
  
  public galleryCurrentPage = toSignal(this.#galleryCurrentPage$) as Signal<number>
  
  public setGalleryCurrentPage(page: number): void {
    this.#galleryCurrentPage$.next(page)
  }

  public resetGalleryCurrentPage(): void {
    this.#galleryCurrentPage$.next(1)
  }
}