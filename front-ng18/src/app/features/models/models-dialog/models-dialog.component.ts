import { Component, ElementRef, effect, output, viewChildren } from '@angular/core';

@Component({
  selector: 'app-models-dialog',
  standalone: true,
  imports: [],
  templateUrl: './models-dialog.component.html',
  styleUrl: './models-dialog.component.scss'
})
export class ModelsDialogComponent {
  dialog = viewChildren<ElementRef>('dialog');
  close = output<void>();

  constructor() {
    effect(() => {
      if (this.dialog()) {
        this.dialog()[0].nativeElement.showModal()
      }
    })
  }

  handleClose() {
    this.close.emit();
  }
}