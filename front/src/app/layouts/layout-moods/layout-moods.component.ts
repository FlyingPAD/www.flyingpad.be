import { Component, inject, OnDestroy, Signal } from '@angular/core';
import { AuthenticationService } from '../../services/http/authentication.service';
import { UserService } from '../../services/http/user.service';
import { MenuService } from '../../services/user-interface/menu.service';

@Component({
  selector: 'app-layout-moods',
  templateUrl: './layout-moods.component.html',
  styleUrl: './layout-moods.component.scss'
})
export class LayoutMoodsComponent implements OnDestroy {
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