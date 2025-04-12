import { Component, inject } from '@angular/core';
import { UserService } from '../../services/http/user.service';
import { DashboardService } from '../../services/dashboard.service';
import { DashboardViewMode } from '../../enumerations/view-modes';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  #userService = inject(UserService)
  #dashboardService = inject(DashboardService)

  public viewMode = this.#dashboardService.dashboardViewMode
  public viewModes = DashboardViewMode

  public user = this.#userService.user

  public setViewMode(viewMode: DashboardViewMode): void {
    this.#dashboardService.setDashboardViewMode(viewMode)
  }
}