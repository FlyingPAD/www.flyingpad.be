import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-time-value-half',
  templateUrl: './time-value-half.component.html',
  styleUrl: './time-value-half.component.scss'
})
export class TimeValueHalfComponent {
  #themeService = inject(ThemeService);

  /** Taille de l'icône (par exemple "24px", "2em", etc.) */
  @Input() size = '24px';
  /** Couleur principale de la note (symbole musical) */
  @Input() noteColor?: string;
  /** Couleur de la portée (stave) */
  @Input() staveColor?: string;

  public getNoteColor(): string {
    // Par défaut, la note sera noire
    return this.noteColor ?? this.#themeService.getCurrentColor() ?? '#000000';
  }

  public getStaveColor(): string {
    // Par défaut, la portée est en gris clair
    return this.staveColor ?? '#b3b3b3';
  }
}
