import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-bottom-icon-page-previous',
  templateUrl: './bottom-icon-page-previous.component.html'
})
export class BottomIconPagePreviousComponent {
  @Output() previousPage = new EventEmitter<void>()

  public handlePreviousPage(): void {
    this.previousPage.emit()
  }
}