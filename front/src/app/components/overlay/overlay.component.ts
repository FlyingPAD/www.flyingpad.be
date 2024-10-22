import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-overlay',
  templateUrl: './overlay.component.html',
  styleUrl: './overlay.component.scss'
})
export class OverlayComponent {
  @Input() isOverlayOn: boolean = false
  @Input() isMenuOn: boolean = false
  @Output() emitter = new EventEmitter()

  handleEmitter(): void {
    this.emitter.emit()
  }
}