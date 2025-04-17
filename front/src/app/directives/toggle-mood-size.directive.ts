import { Directive, HostListener, inject } from '@angular/core';
import { MoodsGalleryService } from '../services/user-interface/moods-gallery.service';

@Directive({
  selector: '[appToggleMoodSize]'
})
export class ToggleMoodSizeDirective {
  #moodsGalleryService = inject(MoodsGalleryService)

  @HostListener('click')
  @HostListener('window:keydown', ['$event'])
  toggleMoodSize(event?: KeyboardEvent): void {
    if (!event || event.key === '+') {
      this.#moodsGalleryService.toggleMoodSize()
    }
  }
}