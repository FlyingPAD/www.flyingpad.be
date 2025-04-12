import { Directive, HostListener, inject } from '@angular/core';
import { MenuService } from '../services/menu.service';

@Directive({
  selector: '[appToggleRightMenu]'
})
export class ToggleMenuRightDirective {
  #menuService = inject(MenuService)

  @HostListener('click')
  @HostListener('window:keydown', ['$event'])
  toggleMoodInfo(event?: KeyboardEvent): void {
    if (!event || event.key === 'Enter') {
      this.#menuService.toggleRightMenu()
    }
  }
}