import { Component, EventEmitter, inject, Input, Output } from '@angular/core';

@Component({
  selector: 'app-bottom-bar-larger',
  templateUrl: './bottom-bar-larger.component.html',
  styleUrl: './bottom-bar-larger.component.scss'
})
export class BottomBarLargerComponent {
  @Input() contentType: string = ''

  @Output() rotation = new EventEmitter<number>()
  @Output() rotateLeft = new EventEmitter<void>()
  @Output() rotateRight = new EventEmitter<void>()
  @Output() random = new EventEmitter<void>()
  @Output() reset = new EventEmitter<void>()
  @Output() info = new EventEmitter<void>()

  public handleRotation(angle: number): void {
    this.rotation.emit(angle)
  }
  public handleRandomRotation(): void {
    this.random.emit()
  }
  public handleRotateLeft(): void {
    this.rotateLeft.emit()
  }
  public handleRotateRight(): void {
    this.rotateRight.emit()
  }
  public handleReset(): void {
    this.reset.emit()
  }
  public handleInfo(): void {
    this.info.emit()
  }
}