import { Directive, HostListener, inject } from '@angular/core';
import { MenuService } from '../services/user-interface/menu.service';

@Directive({
  selector: '[appToggleRightMenu]'
})
export class ToggleMenuRightDirective {
  #menuService = inject(MenuService)

  @HostListener('click')
  @HostListener('window:keydown', ['$event'])
  toggleMoodInfo(event?: KeyboardEvent): void {
    if (!event || event.key === 'Control') {
      this.#menuService.toggleRightMenu()
    }
  }
}