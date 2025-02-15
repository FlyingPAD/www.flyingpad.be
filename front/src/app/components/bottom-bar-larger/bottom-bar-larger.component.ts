import { Component, EventEmitter, inject, Input, Output } from '@angular/core';

@Component({
  selector: 'app-bottom-bar-larger',
  templateUrl: './bottom-bar-larger.component.html',
  styleUrl: './bottom-bar-larger.component.scss'
})
export class BottomBarLargerComponent {
  @Input() contentType: string = 'standard'
}