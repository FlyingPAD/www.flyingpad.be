import { Component, inject } from '@angular/core';
import { DisplayModes } from '../../../enumerations/display-modes';
import { DisplayService } from '../../../services/user-interface/display.service';

@Component({
  selector: 'app-banner-pad-station',
  templateUrl: './banner-pad-station.component.html',
  styleUrl: './banner-pad-station.component.scss'
})
export class BannerPadStationComponent {
  #displayService = inject(DisplayService)

  public displayInfo = this.#displayService.displayInfo
  public displayModes = DisplayModes
}