import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../../services/user-interface/theme.service';

@Component({
  selector: 'app-icon-media',
  templateUrl: './icon-media.component.html'
})
export class IconMediaComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }
}