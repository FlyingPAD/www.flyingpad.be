import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-bottom-item-position',
  templateUrl: './bottom-item-position.component.html'
})
export class BottomItemPositionComponent {
  @Input() currentIndex!: number
  @Input() totalItems: number | undefined 
}