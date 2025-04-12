import { Component, inject } from '@angular/core';
import { StatisticsService } from '../../../services/http/statistics.service';

@Component({
  selector: 'app-dashboard-edition-menu',
  templateUrl: './dashboard-edition-menu.component.html',
  styleUrl: './dashboard-edition-menu.component.scss'
})
export class DashboardEditionMenuComponent {
  #statisticsService = inject(StatisticsService)
  public statistics = this.#statisticsService.statistics
}