import { Component, inject } from '@angular/core';
import { DashboardViewMode } from '../../../enumerations/view-modes';
import { DashboardService } from '../../../services/user-interface/dashboard.service';

@Component({
  selector: 'app-bottom-icon-dashboard-status',
  templateUrl: './bottom-icon-dashboard-status.component.html'
})
export class BottomIconDashboardStatusComponent {
  #dashboardService = inject(DashboardService)

  public currentViewMode = this.#dashboardService.dashboardViewMode
  public viewModes = DashboardViewMode
  
  public setViewMode(): void {
    this.#dashboardService.setDashboardViewMode(DashboardViewMode.Status)
  }
}