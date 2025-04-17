import { Component, inject } from '@angular/core';
import { DashboardViewMode } from '../../../enumerations/view-modes';
import { DashboardService } from '../../../services/user-interface/dashboard.service';

@Component({
  selector: 'app-bottom-icon-dashboard-edition',
  templateUrl: './bottom-icon-dashboard-edition.component.html'
})
export class BottomIconDashboardEditionComponent {
  #dashboardService = inject(DashboardService)

  public currentViewMode = this.#dashboardService.dashboardViewMode
  public viewModes = DashboardViewMode
  
  public setViewMode(): void {
    this.#dashboardService.setDashboardViewMode(DashboardViewMode.Edition)
  }
}