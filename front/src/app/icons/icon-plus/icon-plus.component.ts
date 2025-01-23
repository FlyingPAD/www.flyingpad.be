import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/display/theme.service';

@Component({
  selector: 'app-icon-plus',
  templateUrl: './icon-plus.component.html'
})
export class IconPlusComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'
  @Input() direction: string = 'vertical'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }

  public getTransform(): string {
    switch (this.direction) {
      case 'vertical':
        return 'rotate(0, 600, 600)'
      case 'diagonal':
        return 'rotate(45, 600, 600)'
      // Default : 'Vertical'
      default:
        return 'rotate(0, 600, 600)'
    }
  }
}