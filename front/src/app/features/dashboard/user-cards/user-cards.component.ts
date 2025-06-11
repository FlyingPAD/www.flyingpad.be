import { Component, inject, Input } from '@angular/core';
import { User } from '../../../interfaces/user';
import { Router } from '@angular/router';
import { DashboardService } from '../../../services/user-interface/dashboard.service';
import { DashboardViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-user-cards',
  templateUrl: './user-cards.component.html',
  styleUrl: './user-cards.component.scss'
})
export class UserCardsComponent {
  #router = inject(Router)
  #dashboardService = inject(DashboardService)

  @Input() user!: User

  public currentViewMode = this.#dashboardService.dashboardViewMode
  public viewModes = DashboardViewMode

  public goTo(page: string): void {
    this.#router.navigateByUrl(page)
  }

  public setViewMode(mode: DashboardViewMode): void {
    this.#dashboardService.setDashboardViewMode(mode)
  }
}