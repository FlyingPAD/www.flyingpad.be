import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-logo-youtube',
  templateUrl: './logo-youtube.component.html'
})
export class LogoYoutubeComponent {
  @Input() size: string = '75px'
  @Input() gradientStart: string = '#E52D27'
  @Input() gradientEnd: string = '#BF171D'
  @Input() logoColor: string = '#FFFFFF'
}