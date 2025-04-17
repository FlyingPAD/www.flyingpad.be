import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/user-interface/theme.service';

@Component({
  selector: 'app-time-value-rest-quarter',
  templateUrl: './time-value-rest-quarter.component.html'
})
export class TimeValueRestQuarterComponent {
  #themeService = inject(ThemeService)

  @Input() size: string = '24px'
  @Input() staffColor: string = '#b3b3b3'
  @Input() noteColor?: string

  public getNoteColor(): string {
    return this.noteColor ?? this.#themeService.getCurrentColor()
  }
}