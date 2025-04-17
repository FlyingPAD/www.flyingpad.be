import { Component, inject } from '@angular/core';
import { MenuService } from '../../services/user-interface/menu.service';
import { DisplayService } from '../../services/user-interface/display.service';

@Component({
  selector: 'app-right-column',
  templateUrl: './right-column.component.html',
  styleUrl: './right-column.component.scss'
})
export class RightColumnComponent {
  #menuService = inject(MenuService)
  #displayService = inject(DisplayService)

  public displayMode = this.#displayService.displayInfo().mode.valueOf()
  public rightColumnIsActive = this.#menuService.isRightMenuOn

  public menuTrigger(): void {
    this.#menuService.toggleRightMenu()
  }
}