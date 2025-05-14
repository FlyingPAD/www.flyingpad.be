import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-logo-facebook',
  templateUrl: './logo-facebook.component.html'
})
export class LogoFacebookComponent {
  @Input() size: string = '75px'
  @Input() colorPrimary: string = '#3b5998'
  @Input() colorSecondary: string = '#ffffff'
}