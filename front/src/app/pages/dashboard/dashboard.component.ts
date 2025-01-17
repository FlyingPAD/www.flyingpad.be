import { Component, inject, Signal } from '@angular/core';
import { UserService } from '../../services/user.service';
import { User } from '../../interfaces/user';
import { Player } from '../../models/player';
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
  public user : User = this.#userService.appUser
  public player : Player = this.#userService.player

  public updateMenuState(menuState : string): void {
    this.#dashboardService.updateMenuState(menuState)
  }
}