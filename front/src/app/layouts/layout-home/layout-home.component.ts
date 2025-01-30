import { Component, inject, Signal } from '@angular/core';
import { MenuService } from '../../services/menu.service';
import { AuthenticationService } from '../../services/authentication.service';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-layout-home',
  templateUrl: './layout-home.component.html',
  styleUrl: './layout-home.component.scss'
})
export class LayoutHomeComponent {
  #menuService = inject(MenuService)
  #authService = inject(AuthenticationService)
  #userService = inject(UserService)

  public isLeftMenuOn : Signal<boolean | undefined> = this.#menuService.isLeftMenuOn
  public isUserConnected : Signal<boolean | undefined> = this.#authService.isConnected

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