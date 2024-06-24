import { Component, ElementRef, effect, output, viewChildren } from '@angular/core';

@Component({
  selector: 'app-link-dialog',
  standalone: true,
  imports: [],
  templateUrl: './link-dialog.component.html',
  styleUrl: './link-dialog.component.scss'
})
export class LinkDialogComponent {
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