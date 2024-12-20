import { Component, inject } from '@angular/core';
import { MenuService } from '../../services/display/menu.service';

@Component({
  selector: 'app-right-column',
  templateUrl: './right-column.component.html',
  styleUrl: './right-column.component.scss'
})
export class RightColumnComponent {
  #menuService = inject(MenuService)

  rightColumnIsActive = this.#menuService.isRightMenuOn

  menuTrigger(): void {
    this.#menuService.toggleRightMenu()
  }
}