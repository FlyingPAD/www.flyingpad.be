import { Component, EventEmitter, inject, Output } from '@angular/core';
import { ImageUrlService } from '../../services/display/image-url.service';
import { LanguageService } from '../../services/display/language.service';

@Component({
  selector: 'app-header-home',
  templateUrl: './header-home.component.html',
  styleUrl: './header-home.component.scss'
})
export class HeaderHomeComponent {
  @Output() toggleMenu = new EventEmitter<void>()

  #languageService = inject(LanguageService)
  #imageUrlService = inject(ImageUrlService)

  public currentLanguage = this.#languageService.currentLanguage

  isLanguageMenuON : boolean = false

  public handleMenuToggle(): void {
    this.toggleMenu.emit()
  }

  public toggleLanguageMenu(): void {
    this.isLanguageMenuON = !this.isLanguageMenuON
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
  }
}