import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { LanguageService } from '../../services/language.service';
import { ImageUrlService } from '../../services/image-url.service';
import { SupportedLanguages } from '../../enumerations/supported-languages';

@Component({
  selector: 'app-language-menu-header',
  templateUrl: './language-menu-header.component.html',
  styleUrl: './language-menu-header.component.scss'
})
export class LanguageMenuHeaderComponent {
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