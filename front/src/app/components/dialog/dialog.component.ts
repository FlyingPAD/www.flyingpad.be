import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrl: './dialog.component.scss'
})
export class DialogComponent {
  @Output() dialog = new EventEmitter<void>()

  handleDialog(): void {
    this.dialog.emit()
  }
}
