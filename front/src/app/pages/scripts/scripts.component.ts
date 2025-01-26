import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { ButtonTopService } from '../../services/display/button-top.service';

@Component({
  selector: 'app-scripts',
  templateUrl: './scripts.component.html',
  styleUrl: './scripts.component.scss'
})
export class ScriptsComponent implements OnInit, OnDestroy {
  #toTopButtonService = inject(ButtonTopService)
  public currentScript: string = 'introduction'

  ngOnInit(): void {
    this.#toTopButtonService.setShowButtonTop(true)
  }

  ngOnDestroy(): void {
    this.#toTopButtonService.setShowButtonTop(false)
  }
  public selectScript(scriptName: string): void {
    this.currentScript = scriptName
  }
}