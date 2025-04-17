import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { SupportedLanguages } from '../../enumerations/supported-languages';
import { ImageUrlService } from '../../services/user-interface/image-url.service';
import { LanguageService } from '../../services/user-interface/language.service';

@Component({
  selector: 'app-language-menu-home',
  templateUrl: './language-menu-home.component.html',
  styleUrl: './language-menu-home.component.scss'
})
export class LanguageMenuHomeComponent {
  #languageService = inject(LanguageService)
  #imageUrlService = inject(ImageUrlService)
  currentLanguage = this.#languageService.currentLanguage

  @Input() isMenuOn: boolean = false
  @Output() menuToggle = new EventEmitter<void>()

  supportedLanguages = Object.values(SupportedLanguages)

  switchLanguage(language: string): void {
    this.#languageService.setLanguage(language)
    this.menuToggle.emit()
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageUrlService.getImageURLNoTheme(folderName, imageName, imageExtension)
  }
}