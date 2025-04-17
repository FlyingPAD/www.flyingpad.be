import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/user-interface/theme.service';

@Component({
  selector: 'app-icon-wheel',
  templateUrl: './icon-wheel.component.html'
})
export class IconWheelComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }
}