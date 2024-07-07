import { Component } from '@angular/core';

@Component({
  selector: 'app-right-column',
  templateUrl: './right-column.component.html',
  styleUrl: './right-column.component.scss'
})
export class RightColumnComponent {
  columnOut : boolean = true
  menuTrigger(): void {
    this.columnOut = !this.columnOut
  }
}
