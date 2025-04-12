import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { DisplayService } from '../../../services/display.service';
import { DisplayModes } from '../../../enumerations/display-modes';

@Component({
  selector: 'app-bottom-icon-diaporama',
  templateUrl: './bottom-icon-diaporama.component.html'
})
export class BottomIconDiaporamaComponent {
  #displayService = inject(DisplayService)

  @Input() isDiaporamaActive: boolean = false
  @Input() isShuffleActive: boolean = false

  @Output() startDiaporama = new EventEmitter<void>()
  @Output() stopDiaporama = new EventEmitter<void>()

  public displayInfo = this.#displayService.displayInfo

  public displayModes = DisplayModes
  

  public handleStartDiaporama(): void {
    this.startDiaporama.emit()
  }

  public handleStopDiaporama(): void {
    this.stopDiaporama.emit()
  }
}