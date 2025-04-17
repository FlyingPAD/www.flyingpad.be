import { Component, HostListener, inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LanguageService } from './services/user-interface/language.service';
import { DisplayService } from './services/user-interface/display.service';
import { FullScreenService } from './services/user-interface/full-screen.service';
import { ThemeService } from './services/user-interface/theme.service';
import { GdprService } from './services/gdpr.service';
import { MenuService } from './services/user-interface/menu.service';
import { ButtonTopService } from './services/user-interface/button-top.service';
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