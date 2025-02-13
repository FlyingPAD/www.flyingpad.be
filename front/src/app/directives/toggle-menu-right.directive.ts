import { Directive, HostListener, inject } from '@angular/core';
import { MenuService } from '../services/menu.service';

@Directive({
  selector: '[appToggleRightMenu]'
})
export class ToggleMenuRightDirective {
  #menuService = inject(MenuService)

  @HostListener('click')
  onClick(): void {
    this.#menuService.toggleRightMenu()
  }
}