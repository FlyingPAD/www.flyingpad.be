import { Component, inject } from '@angular/core';
import { LanguageService } from '../../services/user-interface/language.service';
import { DisplayService } from '../../services/user-interface/display.service';
import { FullScreenService } from '../../services/user-interface/full-screen.service';
import { Theme } from '../../enumerations/supported-themes';
import { ThemeService } from '../../services/user-interface/theme.service';
import { ImageUrlService } from '../../services/user-interface/image-url.service';
import { SupportedLanguages } from '../../enumerations/supported-languages';

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
  #imageUrlService = inject(ImageUrlService)

  public currentLanguage = this.#languageService.currentLanguage
  public displayInfos = this.#displayService.displayInfo
  public isFullScreen = this.#fullScreenService.isFullscreen
  public currentTheme = this.#themeService.currentTheme
  public Theme = Theme
  public isLanguageMenuON: boolean = false
  public supportedLanguages: string[] = Object.values(SupportedLanguages)

  get themeKeys(): (keyof typeof Theme)[] {
    return Object.keys(this.Theme) as Array<keyof typeof Theme>
  }

  public currentThemeKey(): keyof typeof Theme {
    return Object.keys(this.Theme).find( key => this.Theme[key as keyof typeof Theme] === this.currentTheme() ) as keyof typeof Theme
  }

  public changeTheme(selectedThemeKey: keyof typeof Theme): void {
    const selectedTheme = this.Theme[selectedThemeKey]
    this.#themeService.setTheme(selectedTheme)
  }

  public switchLanguage(language: string): void {
    this.#languageService.setLanguage(language)
    this.isLanguageMenuON = false
  }

  public toggleFullScreen(): void {
    this.#fullScreenService.toggleFullscreen()
  }

  public async factorySettings(): Promise<void> {
    await this.#fullScreenService.exitFullscreen()
    this.#languageService.resetLanguage()
    this.#themeService.setDefaultTheme()
  }

  public languageMenuToggle(): void {
    this.isLanguageMenuON = !this.isLanguageMenuON
  }

  public getImageURL(theme: boolean, folderName: string, imageName: string, imageExtension: string): string {
    if (theme) return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
    else return this.#imageUrlService.getImageURLNoTheme(folderName, imageName, imageExtension)
  }
}