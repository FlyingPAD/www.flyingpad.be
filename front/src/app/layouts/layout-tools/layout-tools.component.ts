import { Component, inject, Signal } from '@angular/core';
import { MenuService } from '../../services/menu.service';
import { AuthenticationService } from '../../services/system/authentication.service';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-layout-tools',
  templateUrl: './layout-tools.component.html',
  styleUrl: './layout-tools.component.scss'
})
export class LayoutToolsComponent {
  #menuService = inject(MenuService)
  #authService = inject(AuthenticationService)
  #userService = inject(UserService)

  public isConnected : Signal<boolean | undefined> = this.#authService.isConnected

  public toggleLeftMenu(): void {
    this.#menuService.toggleLeftMenu()
  }

  public logout(): void {
    this.#authService.logout()
    this.#userService.setDefaultUser()
  }
}