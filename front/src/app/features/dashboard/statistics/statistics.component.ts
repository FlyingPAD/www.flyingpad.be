import { Component, inject, OnInit } from '@angular/core';
import { StatisticsService } from '../../../services/statistics.service';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrl: './statistics.component.scss'
})
export class StatisticsComponent implements OnInit {
  #statisticsService = inject(StatisticsService)
  public statistics = this.#statisticsService.statistics

  ngOnInit(): void {
    this.#statisticsService.getStatistics()
  }
}