import { Component, HostListener, inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LanguageService } from './services/language.service';
import { DisplayService } from './services/display.service';
import { FullScreenService } from './services/full-screen.service';
import { ThemeService } from './services/theme.service';
import { GdprService } from './services/gdpr.service';
import { MenuService } from './services/menu.service';
import { ButtonTopService } from './services/button-top.service';
import { TokenService } from './services/token.service';
import { AuthenticationService } from './services/http/authentication.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  #displayService = inject(DisplayService)
  #fullScreenService = inject(FullScreenService)
  #themeService = inject(ThemeService)
  #languageService = inject(LanguageService)
  #menuService = inject(MenuService)
  #gdprService = inject(GdprService)
  #authenticationService = inject(AuthenticationService)
  #tokenService = inject(TokenService)
  #buttonTopService = inject(ButtonTopService)
  #router = inject(Router)

  public gdprStatus = this.#gdprService.currentStatus
  public showButtonState = this.#buttonTopService.showButtonTop

  ngOnInit(): void {
    let token = this.#tokenService.retrieveToken()
    if (token) { this.#authenticationService.authenticate(token) }
  }

  // Global shortcuts
  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Escape':
        this.#router.navigateByUrl('/')
        break
      case 'F1':
        this.#menuService.toggleLeftMenu()
        break
    }
  }
}