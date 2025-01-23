import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-logo-soundcloud',
  templateUrl: './logo-soundcloud.component.html'
})
export class LogoSoundcloudComponent {
  @Input() size: string = '75px'
  @Input() backgroundColor: string = '#f50'
  @Input() iconColor: string = '#fff'
}