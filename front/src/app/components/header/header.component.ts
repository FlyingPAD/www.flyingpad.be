import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {
  #imageURLService = inject(ImageUrlService)

  @Input() isMenuON : boolean = false
  @Input() userIsConnected : boolean | null = false
  @Output() menuTriggerEmitter = new EventEmitter()
  @Output() loginTriggerEmitter = new EventEmitter()
  @Output() logoutTriggerEmitter = new EventEmitter()

  handleMenuTrigger(): void {
    this.menuTriggerEmitter.emit()
  }
  handleLoginTrigger(): void {
    this.loginTriggerEmitter.emit()
  }
  handleLogoutTrigger(): void {
    this.logoutTriggerEmitter.emit()
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}