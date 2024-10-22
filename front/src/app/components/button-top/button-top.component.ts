import { Component, HostListener, inject } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';

@Component({
  selector: 'app-button-top',
  templateUrl: './button-top.component.html',
  styleUrl: './button-top.component.scss'
})
export class ButtonTopComponent {
  #imageURLService = inject(ImageUrlService)
  public showButton: boolean = false

  @HostListener('window:scroll', ['$event'])
  onWindowScroll(): void {
    let threshold = 100
    let currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.showButton = currentScrollPosition > threshold
  }

  public toTop(): void {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}