import { Component, inject } from '@angular/core';
import { MenuService } from '../../services/menu.service';
import { AuthenticationService } from '../../services/system/authentication.service';
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

  public isLeftMenuOn = this.#menuService.isLeftMenuOn
  public isUserConnected = this.#authService.isConnected

  public toggleLeftMenu(): void {
    this.#menuService.toggleLeftMenu()
  }

  public logout(): void {
    this.#authService.logout()
    this.#userService.setDefaultUser()
  }
}