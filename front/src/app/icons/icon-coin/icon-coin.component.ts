import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/display/theme.service';

@Component({
  selector: 'app-icon-coin',
  templateUrl: './icon-coin.component.html'
})
export class IconCoinComponent {
  #themeService = inject(ThemeService)

  @Input() size = '24px'
  @Input() colorOuter? : string
  @Input() colorInner? : string

  public getInnerColor(): string {
    return this.colorInner ?? this.#themeService.getCurrentColor()
  }

  public getOuterColor(): string {
    return this.colorOuter ?? '#ffc843'
  }
}