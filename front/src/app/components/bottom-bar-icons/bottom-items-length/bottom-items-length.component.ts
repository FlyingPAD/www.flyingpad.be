import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-bottom-items-length',
  templateUrl: './bottom-items-length.component.html'
})
export class BottomItemsLengthComponent {
  @Input() itemsLength: number | undefined
}