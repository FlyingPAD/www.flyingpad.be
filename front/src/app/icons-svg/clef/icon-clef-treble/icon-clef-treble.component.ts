import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../../services/user-interface/theme.service';

@Component({
  selector: 'app-icon-clef-treble',
  templateUrl: './icon-clef-treble.component.html'
})
export class IconClefTrebleComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }
}