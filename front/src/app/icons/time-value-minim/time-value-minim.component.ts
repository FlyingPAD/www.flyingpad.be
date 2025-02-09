import { Component, inject, Input } from '@angular/core';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-time-value-minim',
  templateUrl: './time-value-minim.component.html'
})
export class TimeValueMinimComponent {
  #themeService = inject(ThemeService);

  /** Taille de l'icône, par défaut "24px" */
  @Input() size = '24px';
  /** Couleur principale (celle de la note) */
  @Input() noteColor?: string;
  /** Couleur de la portée (stave) */
  @Input() staveColor?: string;

  public getNoteColor(): string {
    // Retourne la couleur principale ou, par défaut, celle définie dans ton service de thème
    return this.noteColor ?? this.#themeService.getCurrentColor();
  }

  public getStaveColor(): string {
    // Retourne la couleur de la portée ou, par défaut, du gris clair (#b3b3b3)
    return this.staveColor ?? '#b3b3b3';
  }
}