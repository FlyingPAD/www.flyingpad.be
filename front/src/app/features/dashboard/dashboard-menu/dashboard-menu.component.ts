import { Component, EventEmitter, inject, Input, Output, Signal } from '@angular/core';
import { User } from '../../../interfaces/user';
import { DashboardService } from '../../../services/dashboard.service';

@Component({
  selector: 'app-dashboard-menu',
  templateUrl: './dashboard-menu.component.html',
  styleUrl: './dashboard-menu.component.scss'
})
export class DashboardMenuComponent {
  @Input() user!: User
  @Output() menuState = new EventEmitter<string>()

  #dashboardService = inject(DashboardService)

  public dashboardMenuState: Signal<string> = this.#dashboardService.dashboardMenuState

  public handleDashBoardMenuState(menuState: string): void {
    this.menuState.emit(menuState)
  }
}