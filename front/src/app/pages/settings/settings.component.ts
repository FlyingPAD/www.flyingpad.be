import { Component, inject } from '@angular/core';
import { LanguageService } from '../../services/language.service';
import { DisplayService } from '../../services/display.service';
import { FullScreenService } from '../../services/full-screen.service';
import { Theme } from '../../enumerations/themes';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.scss']
})
export class SettingsComponent {
  #languageService = inject(LanguageService)
  #displayService = inject(DisplayService)
  #fullScreenService = inject(FullScreenService)
  #themeService = inject(ThemeService)

  currentLanguage = this.#languageService.currentLanguage
  displayInfos = this.#displayService.displayInfo
  isFullScreen = this.#fullScreenService.isFullscreen
  currentTheme = this.#themeService.currentTheme
  Theme = Theme

  // Récupérer la liste des clés de thèmes
  get themeKeys(): (keyof typeof Theme)[] {
    return Object.keys(this.Theme) as Array<keyof typeof Theme>;
  }

  // Retourne la clé du thème actuellement sélectionné
  currentThemeKey(): keyof typeof Theme {
    return Object.keys(this.Theme).find(
      key => this.Theme[key as keyof typeof Theme] === this.currentTheme()
    ) as keyof typeof Theme
  }

  // Méthode pour changer le thème en fonction de la sélection
  changeTheme(selectedThemeKey: keyof typeof Theme): void {
    const selectedTheme = this.Theme[selectedThemeKey];
    this.#themeService.setTheme(selectedTheme);
  }

  switchLanguage(language: string): void {
    this.#languageService.setLanguage(language);
  }

  toggleFullScreen(): void {
    this.#fullScreenService.toggleFullscreen();
  }

  async factorySettings(): Promise<void> {
    await this.#fullScreenService.exitFullscreen();
    this.#languageService.resetLanguage();
    this.#themeService.setDefaultTheme();
  }
}