import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';
import { LanguageService } from '../../services/language.service';
import { DisplayService } from '../../services/display.service';

@Component({
  selector: 'app-left-column',
  templateUrl: './left-column.component.html',
  styleUrl: './left-column.component.scss'
})
export class LeftColumnComponent {
  #languageService = inject(LanguageService)
  #imageUrlService = inject(ImageUrlService)
  #displayService = inject(DisplayService)

  public currentLanguage = this.#languageService.currentLanguage
  public displayInfo = this.#displayService.displayInfo

  isLanguageMenuON : boolean = false

  @Input() isLeftMenuOn : boolean | undefined = false
  @Input() isUserConnected : boolean | undefined = false
  @Input() userRole : number = 0
  @Output() menuToggle = new EventEmitter()
  @Output() menuTriggerEmitter = new EventEmitter()
  @Output() logout = new EventEmitter<void>()

  currentYear: number = new Date().getFullYear()

  public handleMenuTrigger(): void {
    this.menuTriggerEmitter.emit()
  }
  public handleMenuToggle(): void {
    this.menuToggle.emit()
  }

  public handleMenuMobile(): void {
    if(this.displayInfo().mode === 'Mobile') {
      this.handleMenuToggle()
    }
  }
  public handleLogout(): void {
    this.logout.emit()
  }

  languageMenuToggle(): void {
    this.isLanguageMenuON = !this.isLanguageMenuON
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
  }
}