import { Component, inject } from '@angular/core';
import { DashboardViewMode } from '../../../enumerations/view-modes';
import { DashboardService } from '../../../services/user-interface/dashboard.service';

@Component({
  selector: 'app-bottom-icon-dashboard-achievements',
  templateUrl: './bottom-icon-dashboard-achievements.component.html'
})
export class BottomIconDashboardAchievementsComponent {
  #dashboardService = inject(DashboardService)

  public currentViewMode = this.#dashboardService.dashboardViewMode
  public viewModes = DashboardViewMode
  
  public setViewMode(): void {
    this.#dashboardService.setDashboardViewMode(DashboardViewMode.Achievements)
  }
}