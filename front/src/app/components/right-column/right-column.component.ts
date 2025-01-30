import { Component, inject } from '@angular/core';
import { MenuService } from '../../services/menu.service';

@Component({
  selector: 'app-right-column',
  templateUrl: './right-column.component.html',
  styleUrl: './right-column.component.scss'
})
export class RightColumnComponent {
  #menuService = inject(MenuService)

  public rightColumnIsActive = this.#menuService.isRightMenuOn

  public menuTrigger(): void {
    this.#menuService.toggleRightMenu()
  }
}