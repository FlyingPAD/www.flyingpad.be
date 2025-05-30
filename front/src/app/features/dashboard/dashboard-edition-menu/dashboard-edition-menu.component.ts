import { Component, inject } from '@angular/core';
import { StatisticsService } from '../../../services/http/statistics.service';
import { Router } from '@angular/router';
import { MoodsGalleryService } from '../../../services/user-interface/moods-gallery.service';
import { GalleryMode } from '../../../enumerations/gallery-mode';
import { GalleryType } from '../../../enumerations/gallery-type';

@Component({
  selector: 'app-dashboard-edition-menu',
  templateUrl: './dashboard-edition-menu.component.html',
  styleUrl: './dashboard-edition-menu.component.scss'
})
export class DashboardEditionMenuComponent {
  #statisticsService = inject(StatisticsService)
  #router = inject(Router)
  #moodsGalleryService = inject(MoodsGalleryService)

  public statistics = this.#statisticsService.statistics

  public goToNewMoods(): void {
    this.#moodsGalleryService.setGalleryMode(GalleryMode.New)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)

    this.#router.navigateByUrl('/central-gallery')
  }
}