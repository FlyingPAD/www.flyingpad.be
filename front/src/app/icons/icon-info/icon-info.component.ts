import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/display/theme.service';

@Component({
  selector: 'app-icon-info',
  templateUrl: './icon-info.component.html'
})
export class IconInfoComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }
}