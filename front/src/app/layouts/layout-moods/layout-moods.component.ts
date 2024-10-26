import { Component, inject } from '@angular/core';
import { AuthenticationService } from '../../services/system/authentication.service';
import { UserService } from '../../services/user.service';
import { MenuService } from '../../services/menu.service';

@Component({
  selector: 'app-layout-moods',
  templateUrl: './layout-moods.component.html',
  styleUrl: './layout-moods.component.scss'
})
export class LayoutMoodsComponent {
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