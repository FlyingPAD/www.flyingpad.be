import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';
import { DisplayService } from '../../services/display.service';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-left-column',
  templateUrl: './left-column.component.html',
  styleUrl: './left-column.component.scss'
})
export class LeftColumnComponent {
  #imageUrlService = inject(ImageUrlService)
  #displayService = inject(DisplayService)

  @Input() isLeftMenuOn : boolean | undefined = false
  @Input() isUserConnected : boolean | undefined = false
  @Output() menuToggle = new EventEmitter()
  @Output() logout = new EventEmitter<void>()

  public displayInfo = this.#displayService.displayInfo
  public currentYear: number = new Date().getFullYear()
  public appVersion = environment.appVersion

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

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
  }
}