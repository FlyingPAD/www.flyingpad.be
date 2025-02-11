import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-time-value-whole',
  templateUrl: './time-value-whole.component.html'
})
export class TimeValueWholeComponent {
  #themeService = inject(ThemeService)

  @Input() size: string = '24px'
  @Input() staffColor: string = '#b3b3b3'
  @Input() noteColor?: string

  public getNoteColor(): string {
    return this.noteColor ?? this.#themeService.getCurrentColor()
  }
}