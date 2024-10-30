import { Component, inject, Signal } from '@angular/core';
import { MenuService } from '../../services/display/menu.service';
import { AuthenticationService } from '../../services/authentication.service';
import { UserService } from '../../services/user.service';
import { DisplayService } from '../../services/display/display.service';

@Component({
  selector: 'app-layout-tools',
  templateUrl: './layout-tools.component.html',
  styleUrl: './layout-tools.component.scss'
})
export class LayoutToolsComponent {
  #menuService = inject(MenuService)
  #authService = inject(AuthenticationService)
  #userService = inject(UserService)
  #displayService = inject(DisplayService)

  public isLeftMenuOn : Signal<boolean | undefined> = this.#menuService.isLeftMenuOn
  public isUserConnected : Signal<boolean | undefined> = this.#authService.isConnected
  public displayInfos = this.#displayService.displayInfo

  public toggleLeftMenu(): void {
    this.#menuService.toggleLeftMenu()
  }

  public closeLeftMenu(): void {
    this.#menuService.closeLeftMenu()
  }
  
  public logout(): void {
    this.#authService.logout()
    this.#userService.setDefaultUser()
  }
}