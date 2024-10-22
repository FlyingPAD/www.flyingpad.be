import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';

@Component({
  selector: 'app-menu-hidden',
  templateUrl: './menu-hidden.component.html',
  styleUrl: './menu-hidden.component.scss'
})
export class MenuHiddenComponent {  
  #imageURLService = inject(ImageUrlService)

  @Input() isMenuON : boolean = false
  @Input() userIsConnected : boolean | null = false
  @Input() userRole : number = 0
  @Output() menuTriggerCustomEmitter = new EventEmitter()
  @Output() menuTriggerEmitter = new EventEmitter()

  currentYear: number = new Date().getFullYear()

  public handleMenuTrigger(): void {
    this.menuTriggerEmitter.emit()
  }
  public handleMenuCustomTrigger(): void {
    this.menuTriggerCustomEmitter.emit()
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string { 
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}