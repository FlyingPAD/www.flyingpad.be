import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-bottom-item-name',
  templateUrl: './bottom-item-name.component.html'
})
export class BottomItemNameComponent {
  @Input() itemName: string | undefined
}