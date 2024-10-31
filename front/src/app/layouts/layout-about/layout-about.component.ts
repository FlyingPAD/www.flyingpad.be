import { Component, inject, Signal } from '@angular/core';
import { AuthenticationService } from '../../services/authentication.service';
import { MenuService } from '../../services/display/menu.service';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-layout-about',
  templateUrl: './layout-about.component.html',
  styleUrl: './layout-about.component.scss'
})
export class LayoutAboutComponent {
  #menuService = inject(MenuService)
  #authService = inject(AuthenticationService)
  #userService = inject(UserService)

  public isLeftMenuOn : Signal<boolean | undefined> = this.#menuService.isLeftMenuOn
  public isUserConnected : Signal<boolean | undefined> = this.#authService.isConnected

  ngOnDestroy(): void {
    this.#menuService.closeLeftMenu()
  }
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