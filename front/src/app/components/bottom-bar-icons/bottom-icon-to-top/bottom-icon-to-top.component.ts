import { Component, HostListener } from '@angular/core';

@Component({
  selector: 'app-bottom-icon-to-top',
  templateUrl: './bottom-icon-to-top.component.html'
})
export class BottomIconToTopComponent {
  public topButtonIsActive: boolean = false

  @HostListener('window:scroll', ['$event'])
  onWindowScroll(): void {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }
}