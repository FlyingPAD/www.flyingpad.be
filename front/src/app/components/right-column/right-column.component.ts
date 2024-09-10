import { Component, inject } from '@angular/core';
import { RightColumnService } from '../../services/right-column.service';

@Component({
  selector: 'app-right-column',
  templateUrl: './right-column.component.html',
  styleUrl: './right-column.component.scss'
})
export class RightColumnComponent {
  rightColumnService = inject(RightColumnService);
  rightColumnIsActive : boolean | undefined = false

  constructor() {
    this.rightColumnIsActive = this.rightColumnService.rightColumnIsActive();
  }
  menuTrigger(): void {
    this.rightColumnService.updateRightColumnState(!this.rightColumnIsActive);
    this.rightColumnIsActive = this.rightColumnService.rightColumnIsActive();
  }
}