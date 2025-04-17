import { Component, EventEmitter, inject, Output } from '@angular/core';
import { ImageUrlService } from '../../services/user-interface/image-url.service';
import { LanguageService } from '../../services/user-interface/language.service';

@Component({
  selector: 'app-header-home',
  templateUrl: './header-home.component.html',
  styleUrl: './header-home.component.scss'
})
export class HeaderHomeComponent {
  @Output() menuToggle = new EventEmitter<void>()

  #languageService = inject(LanguageService)
  #imageUrlService = inject(ImageUrlService)

  public currentLanguage = this.#languageService.currentLanguage

  isLanguageMenuON : boolean = false

  public handleMenuToggle(): void {
    this.menuToggle.emit()
  }

  public toggleLanguageMenu(): void {
    this.isLanguageMenuON = !this.isLanguageMenuON
  }

  public getImageURL(theme: boolean, folderName: string, imageName: string, imageExtension: string): string {
    if(theme) {
      return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
    }
    else {
      return this.#imageUrlService.getImageURLNoTheme(folderName, imageName, imageExtension)
    }
  }
}