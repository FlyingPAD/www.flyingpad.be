import { Component, HostListener, inject } from '@angular/core';
import { ButtonTopService } from '../../services/button-top.service';

@Component({
  selector: 'app-button-top',
  templateUrl: './button-top.component.html',
  styleUrl: './button-top.component.scss'
})
export class ButtonTopComponent {
  #buttonTopService  = inject(ButtonTopService)
  public topButtonisActive = this.#buttonTopService.topButtonisActive
  public toTop(): void {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }

  @HostListener('window:scroll', [])
  onWindowScroll(): void {
    const threshold = 100;
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0;
    this.#buttonTopService .updateTopButtonState(currentScrollPosition > threshold);
  }
}