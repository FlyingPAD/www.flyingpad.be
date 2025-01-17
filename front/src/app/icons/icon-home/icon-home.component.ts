import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/display/theme.service';

@Component({
  selector: 'app-icon-home',
  templateUrl: './icon-home.component.html'
})
export class IconHomeComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }
}