import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-logo-instagram',
  templateUrl: './logo-instagram.component.html'
})
export class LogoInstagramComponent {
  @Input() size: string = '75px';

  // Gradient A
  @Input() gradientAStop1: string = '#fd5'
  @Input() gradientAStop2: string = '#fd5'
  @Input() gradientAStop3: string = '#ff543e'
  @Input() gradientAStop4: string = '#c837ab'

  // Gradient B
  @Input() gradientBStop1: string = '#3771c8'
  @Input() gradientBStop2: string = '#3771c8'
  @Input() gradientBStop3: string = '#60f'
  @Input() gradientBStop3Opacity: number | string = 0
}