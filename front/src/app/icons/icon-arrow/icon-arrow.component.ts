import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/display/theme.service';

@Component({
  selector: 'app-icon-arrow',
  templateUrl: './icon-arrow.component.html'
})
export class IconArrowComponent {
  #themeService = inject(ThemeService);

  @Input() color?: string
  @Input() size: string = '24px'
  @Input() direction: string = 'up'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }

  public getTransform(): string {
    switch (this.direction) {
      case 'up-right':
        return 'rotate(45, 12, 12)'
      case 'right':
        return 'rotate(90, 12, 12)'
      case 'down-right':
        return 'rotate(135, 12, 12)'
      case 'down':
        return 'rotate(180, 12, 12)'
      case 'down-left':
        return 'rotate(225, 12, 12)'
      case 'left':
        return 'rotate(270, 12, 12)'
      case 'up-left':
        return 'rotate(315, 12, 12)'
      // Default : 'UP'
      default:
        return 'rotate(0, 12, 12)'
    }
  }
}