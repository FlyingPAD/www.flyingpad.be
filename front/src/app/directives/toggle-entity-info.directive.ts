import { Directive, HostListener, inject } from '@angular/core';
import { MoodsGalleryService } from '../services/moods-gallery.service';

@Directive({
  selector: '[appToggleEntityInfo]'
})
export class ToggleEntityInfoDirective {
  #moodsGalleryService = inject(MoodsGalleryService)

  @HostListener('click')
  @HostListener('window:keydown', ['$event'])
  toggleMoodInfo(event?: KeyboardEvent): void {
    if (!event || event.key === 'Control') {
      this.#moodsGalleryService.toggleEntityInfo()
    }
  }
}