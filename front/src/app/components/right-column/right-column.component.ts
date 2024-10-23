import { Component, inject } from '@angular/core';
import { RightColumnService } from '../../services/display/right-column.service';

@Component({
  selector: 'app-right-column',
  templateUrl: './right-column.component.html',
  styleUrl: './right-column.component.scss'
})
export class RightColumnComponent {
  #rightColumnService = inject(RightColumnService)

  rightColumnIsActive = this.#rightColumnService.rightColumnIsActive

  menuTrigger(): void {
    this.#rightColumnService.toggleRightColumn()
  }
}