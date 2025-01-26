import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-overlay',
  templateUrl: './overlay.component.html',
  styleUrl: './overlay.component.scss'
})
export class OverlayComponent {
  @Input() isOverlayOn: boolean | undefined = false
  @Output() toggle = new EventEmitter()

  public handleToggle(): void {
    this.toggle.emit()
  }
}