import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../../services/user-interface/theme.service';

@Component({
  selector: 'app-icon-go',
  templateUrl: './icon-go.component.html'
})
export class IconGoComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }
}