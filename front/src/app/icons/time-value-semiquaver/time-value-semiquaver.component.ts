import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-time-value-semiquaver',
  templateUrl: './time-value-semiquaver.component.html'
})
export class TimeValueSemiquaverComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }
}