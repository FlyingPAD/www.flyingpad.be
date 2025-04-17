import { Component, inject } from '@angular/core';
import { DashboardService } from '../../../services/user-interface/dashboard.service';
import { DashboardViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-bottom-icon-dashboard-account',
  templateUrl: './bottom-icon-dashboard-account.component.html'
})
export class BottomIconDashboardAccountComponent {
  #dashboardService = inject(DashboardService)

  public currentViewMode = this.#dashboardService.dashboardViewMode
  public viewModes = DashboardViewMode

  public setViewMode(): void {
    this.#dashboardService.setDashboardViewMode(DashboardViewMode.Account)
  }
}