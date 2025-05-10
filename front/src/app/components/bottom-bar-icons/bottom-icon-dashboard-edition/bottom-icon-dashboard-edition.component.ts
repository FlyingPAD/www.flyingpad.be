import { Component, inject } from '@angular/core';
import { DashboardViewMode } from '../../../enumerations/view-modes';
import { DashboardService } from '../../../services/user-interface/dashboard.service';
import { UserService } from '../../../services/http/user.service';

@Component({
  selector: 'app-bottom-icon-dashboard-edition',
  templateUrl: './bottom-icon-dashboard-edition.component.html'
})
export class BottomIconDashboardEditionComponent {
  #dashboardService = inject(DashboardService)
  #userService = inject(UserService)

  public currentViewMode = this.#dashboardService.dashboardViewMode
  public viewModes = DashboardViewMode
  public user = this.#userService.user

  public setViewMode(): void {
    this.#dashboardService.setDashboardViewMode(DashboardViewMode.Edition)
  }
}