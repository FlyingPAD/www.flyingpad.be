import { Component, inject } from '@angular/core';
import { GdprService } from '../../services/gdpr.service';
import { LanguageService } from '../../services/display/language.service';

@Component({
  selector: 'app-gdpr',
  templateUrl: './gdpr.component.html',
  styleUrl: './gdpr.component.scss'
})
export class GdprComponent {
  #languageService = inject(LanguageService)
  #gdprService = inject(GdprService)
  hideAnimation = false

  setStatus(status: boolean): void {
    this.hideAnimation = true
    
    setTimeout(() => {
      this.#gdprService.setCurrentStatus(status)
    }, 500)
  }
}