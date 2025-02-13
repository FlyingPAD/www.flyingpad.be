import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { ButtonTopService } from '../../services/button-top.service';
import { ScriptsService } from '../../services/scripts.service';
import { DisplayService } from '../../services/display.service';

@Component({
  selector: 'app-scripts',
  templateUrl: './scripts.component.html',
  styleUrl: './scripts.component.scss'
})
export class ScriptsComponent implements OnInit, OnDestroy {
  #scriptsService = inject(ScriptsService)
  #toTopButtonService = inject(ButtonTopService)
  #displayService = inject(DisplayService)

  public currentScript = this.#scriptsService.scriptsMenuState
  public displayMode = this.#displayService.displayInfo().mode.valueOf()

  ngOnInit(): void {
    this.#toTopButtonService.setShowButtonTop(true)
  }

  ngOnDestroy(): void {
    this.#toTopButtonService.setShowButtonTop(false)
  }
  public updateMenuState(menuState: string): void {
    this.#scriptsService.updateScriptMenuState(menuState)
  }
}