import { Component, HostListener, inject, OnDestroy, OnInit, Renderer2 } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { LanguageService } from './services/user-interface/language.service';
import { DisplayService } from './services/user-interface/display.service';
import { ThemeService } from './services/user-interface/theme.service';
import { GdprService } from './services/gdpr.service';
import { MenuService } from './services/user-interface/menu.service';
import { ButtonTopService } from './services/user-interface/button-top.service';
import { TokenService } from './services/token.service';
import { AuthenticationService } from './services/http/authentication.service';
import { filter, Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit, OnDestroy {
  #displayService = inject(DisplayService)
  #themeService = inject(ThemeService)
  #languageService = inject(LanguageService)
  #menuService = inject(MenuService)
  #gdprService = inject(GdprService)
  #authenticationService = inject(AuthenticationService)
  #tokenService = inject(TokenService)
  #buttonTopService = inject(ButtonTopService)
  #router = inject(Router)
  #renderer = inject(Renderer2)

  #destroy$ = new Subject<void>()

  public gdprStatus = this.#gdprService.currentStatus
  public showButtonState = this.#buttonTopService.showButtonTop

  public showGDPR: boolean = false

  ngOnInit(): void {
    setTimeout(() => {this.showGDPR = true}, 3000)
    
    let token = this.#tokenService.retrieveToken()
    if (token) { this.#authenticationService.authenticate(token) }

    this.#router.events
      .pipe(filter((e): e is NavigationEnd => e instanceof NavigationEnd), takeUntil(this.#destroy$))
      .subscribe(e => {
        if (e.urlAfterRedirects.startsWith('/sign-up')) this.#renderer.addClass(document.body, 'signup-page')
        else this.#renderer.removeClass(document.body, 'signup-page')
      })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
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