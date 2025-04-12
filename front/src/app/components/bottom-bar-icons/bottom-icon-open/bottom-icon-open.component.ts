import { Component, EventEmitter, inject, Output } from '@angular/core';
import { DisplayService } from '../../../services/display.service';
import { DisplayModes } from '../../../enumerations/display-modes';

@Component({
  selector: 'app-bottom-icon-open',
  templateUrl: './bottom-icon-open.component.html'
})
export class BottomIconOpenComponent {
  #displayService = inject(DisplayService)

  @Output() openMoodInNewTab = new EventEmitter<void>()

  public displayInfo = this.#displayService.displayInfo

  public DisplayModes = DisplayModes

  public handleOpenMoodInNewTab(): void {
    this.openMoodInNewTab.emit()
  }
}