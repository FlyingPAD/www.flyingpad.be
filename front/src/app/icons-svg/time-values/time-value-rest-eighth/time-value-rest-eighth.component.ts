import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../../services/user-interface/theme.service';

@Component({
  selector: 'app-time-value-rest-eighth',
  templateUrl: './time-value-rest-eighth.component.html'
})
export class TimeValueRestEighthComponent {
  #themeService = inject(ThemeService)

  @Input() size: string = '24px'
  @Input() staffColor: string = '#b3b3b3'
  @Input() noteColor?: string

  public getNoteColor(): string {
    return this.noteColor ?? this.#themeService.getCurrentColor()
  }
}