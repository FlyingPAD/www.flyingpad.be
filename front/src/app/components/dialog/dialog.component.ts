import { Component, inject } from '@angular/core';
import { DialogService } from '../../services/user-interface/dialog.service';

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrl: './dialog.component.scss'
})
export class DialogComponent {
  #dialogService = inject(DialogService)

  public dialogToggle = this.#dialogService.dialogToggle
}