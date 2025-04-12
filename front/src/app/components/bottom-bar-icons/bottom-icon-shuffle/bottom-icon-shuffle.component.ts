import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { DisplayService } from '../../../services/display.service';
import { DisplayModes } from '../../../enumerations/display-modes';

@Component({
  selector: 'app-bottom-icon-shuffle',
  templateUrl: './bottom-icon-shuffle.component.html'
})
export class BottomIconShuffleComponent {
  #displayService = inject(DisplayService)

  @Input() isDiaporamaActive: boolean = false
  @Output() startDiaporama = new EventEmitter<void>()

  public displayInfo = this.#displayService.displayInfo

  public displayModes = DisplayModes

  public handleStartDiaporama(): void {
    this.startDiaporama.emit()
  }
}