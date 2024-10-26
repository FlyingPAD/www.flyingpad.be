import { Component, HostListener, inject, OnInit } from '@angular/core';
import { UserService } from './services/user.service';
import { CustomCookieService } from './services/system/cookie.service';
import { AuthenticationService } from './services/system/authentication.service';
import { Router } from '@angular/router';
import { MenuCustomService } from './services/display/menu-custom.service';
import { LanguageService } from './services/display/language.service';
import { DisplayService } from './services/display/display.service';
import { FullScreenService } from './services/display/full-screen.service';
import { ThemeService } from './services/display/theme.service';
import { GdprService } from './services/system/gdpr.service';
import { RightColumnService } from './services/display/right-column.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
  #languageService = inject(LanguageService)
  #displayService = inject(DisplayService)
  #rightColumnService = inject(RightColumnService)
  #fullScreenService = inject(FullScreenService)
  #themeService = inject(ThemeService)
  #gdprService = inject(GdprService)
  #authService = inject(AuthenticationService)
  #userService = inject(UserService)
  #cookieService = inject(CustomCookieService)
  #menuCustomService = inject(MenuCustomService)
  router = inject(Router)

  gdprStatus = this.#gdprService.currentStatus
  displayInfo = this.#displayService.displayInfo

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
      this.#rightColumnService.enableRightColumn()
    } else {
      this.#rightColumnService.disableRightColumn()
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Escape':
        this.router.navigateByUrl('/')
        break
      case 'F1':
        this.#menuCustomService.triggerMenuCustom()
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