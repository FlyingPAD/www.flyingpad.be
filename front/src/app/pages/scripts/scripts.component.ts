import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { ButtonTopService } from '../../services/user-interface/button-top.service';
import { ScriptsService } from '../../services/user-interface/scripts.service';
import { DisplayService } from '../../services/user-interface/display.service';
import { ScriptsViewMode } from '../../enumerations/view-modes';
import { DisplayModes } from '../../enumerations/display-modes';

@Component({
  selector: 'app-scripts',
  templateUrl: './scripts.component.html',
  styleUrl: './scripts.component.scss'
})
export class ScriptsComponent implements OnInit, OnDestroy {
  #scriptsService = inject(ScriptsService)
  #toTopButtonService = inject(ButtonTopService)
  #displayService = inject(DisplayService)

  public currentViewMode = this.#scriptsService.scriptsViewMode
  public viewModes = ScriptsViewMode
  public displayModes = DisplayModes 
  public displayInfo = this.#displayService.displayInfo

  ngOnInit(): void {
    if(this.displayInfo().mode.valueOf() === DisplayModes.Desktop) {
      this.#toTopButtonService.setShowButtonTop(true)
    }
  }

  ngOnDestroy(): void {
    if(this.displayInfo().mode.valueOf() === DisplayModes.Desktop) {
      this.#toTopButtonService.setShowButtonTop(false)
    }
  }
  
  public setViewMode(viewMode: ScriptsViewMode): void {
    this.#scriptsService.setScriptsViewMode(viewMode)
  }
}