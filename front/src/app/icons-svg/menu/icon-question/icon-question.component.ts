import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../../services/user-interface/theme.service';

@Component({
  selector: 'app-icon-question',
  templateUrl: './icon-question.component.html'
})
export class IconQuestionComponent {
  #themeService = inject(ThemeService)

  @Input() color?: string
  @Input() size: string = '24px'

  public getColor(): string {
    return this.color ?? this.#themeService.getCurrentColor()
  }
}