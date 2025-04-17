import { Directive, HostListener, inject } from '@angular/core';
import { MoodsGalleryService } from '../services/user-interface/moods-gallery.service';

@Directive({
  selector: '[appToggleMoodInfo]'
})
export class ToggleMoodInfoDirective {
  #moodsGalleryService = inject(MoodsGalleryService)

  @HostListener('click')
  @HostListener('window:keydown', ['$event'])
  toggleMoodInfo(event?: KeyboardEvent): void {
    if (!event || event.key === 'Control') {
      this.#moodsGalleryService.toggleMoodInfo()
    }
  }
}