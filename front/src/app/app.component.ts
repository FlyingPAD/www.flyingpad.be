import { Component, HostListener, inject, OnInit } from '@angular/core';
import { UserService } from './services/user.service';
import { CustomCookieService } from './services/cookie.service';
import { AuthenticationService } from './services/authentication.service';
import { Router } from '@angular/router';
import { LanguageService } from './services/display/language.service';
import { DisplayService } from './services/display/display.service';
import { FullScreenService } from './services/display/full-screen.service';
import { ThemeService } from './services/display/theme.service';
import { GdprService } from './services/gdpr.service';
import { MenuService } from './services/display/menu.service';
import { ButtonTopService } from './services/display/button-top.service';

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
  #authService = inject(AuthenticationService)
  #userService = inject(UserService)
  #cookieService = inject(CustomCookieService)
  #buttonTopService = inject(ButtonTopService)
  #router = inject(Router)

  public gdprStatus = this.#gdprService.currentStatus
  public displayInfo = this.#displayService.displayInfo
  public showButtonState = this.#buttonTopService.showButtonTop

  ngOnInit(): void {
    let token = this.#cookieService.retrieveToken()

    if (token) {
      this.#userService.setSpecificUser(token)
      this.#authService.acceptConnection()
    }
    else {
      this.#userService.setDefaultUser()
    }

    if(this.displayInfo().mode === 'Desktop') {
      this.#menuService.openRightMenu()
    } else {
      this.#menuService.closeRightMenu()
    }
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
      // case '1':
      //   this.router.navigateByUrl('/moods')
      //   break
      // case '2':
      //   this.router.navigateByUrl('/tags')
      //   break
      // case '3':
      //   this.router.navigateByUrl('/franchises/gallery')
      //   break
      // case '4':
      //   this.router.navigateByUrl('/moods')
      //   break
      // case '5':
      //   this.router.navigateByUrl('/moods/mood-details')
      //   break
      // case '6':
      //   this.router.navigateByUrl('/tags')
      //   break
      // case '7':
      //   this.router.navigateByUrl('/scripts')
      //   break
      // case '8':
      //   this.router.navigateByUrl('/tools')
      //   break
      // case '9':
      //   this.router.navigateByUrl('/links')
      //   break
    }
  }
}