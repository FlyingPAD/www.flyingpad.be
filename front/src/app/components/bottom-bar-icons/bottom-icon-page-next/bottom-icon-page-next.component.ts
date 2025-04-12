import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-bottom-icon-page-next',
  templateUrl: './bottom-icon-page-next.component.html'
})
export class BottomIconPageNextComponent {
  @Output() nextPage = new EventEmitter<void>()

  public handleNextPage(): void {
    this.nextPage.emit()
  }
}