import { Component, inject, Signal } from '@angular/core';
import { UserService } from '../../services/http/user.service';
import { DashboardService } from '../../services/dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  #userService = inject(UserService)
  #dashboardService = inject(DashboardService)

  public dashboardMenuState : Signal<string> = this.#dashboardService.dashboardMenuState
  public user = this.#userService.user

  public updateMenuState(menuState : string): void {
    this.#dashboardService.updateMenuState(menuState)
  }
}