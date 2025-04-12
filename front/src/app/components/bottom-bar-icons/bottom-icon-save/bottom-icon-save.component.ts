import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-bottom-icon-save',
  templateUrl: './bottom-icon-save.component.html'
})
export class BottomIconSaveComponent {
  @Output() triggerSave = new EventEmitter<void>()

  public handleTriggerSave(): void {
    this.triggerSave.emit()
  }
}