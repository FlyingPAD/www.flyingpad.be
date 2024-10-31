import { Component, inject } from '@angular/core';
import { LanguageService } from '../../services/display/language.service';
import { DisplayService } from '../../services/display/display.service';
import { FullScreenService } from '../../services/display/full-screen.service';
import { Theme } from '../../enumerations/themes';
import { ThemeService } from '../../services/display/theme.service';

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

  get themeKeys(): (keyof typeof Theme)[] {
    return Object.keys(this.Theme) as Array<keyof typeof Theme>;
  }

  public currentThemeKey(): keyof typeof Theme {
    return Object.keys(this.Theme).find(
      key => this.Theme[key as keyof typeof Theme] === this.currentTheme()
    ) as keyof typeof Theme
  }

  public changeTheme(selectedThemeKey: keyof typeof Theme): void {
    const selectedTheme = this.Theme[selectedThemeKey];
    this.#themeService.setTheme(selectedTheme);
  }

  public switchLanguage(language: string): void {
    this.#languageService.setLanguage(language);
  }

  public toggleFullScreen(): void {
    this.#fullScreenService.toggleFullscreen();
  }

  public async factorySettings(): Promise<void> {
    await this.#fullScreenService.exitFullscreen();
    this.#languageService.resetLanguage();
    this.#themeService.setDefaultTheme();
  }
}