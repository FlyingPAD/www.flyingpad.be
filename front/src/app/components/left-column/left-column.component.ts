import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ImageUrlService } from '../../services/display/image-url.service';

@Component({
  selector: 'app-left-column',
  templateUrl: './left-column.component.html',
  styleUrl: './left-column.component.scss'
})
export class LeftColumnComponent {
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