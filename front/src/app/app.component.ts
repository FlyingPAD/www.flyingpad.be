import { Component, HostListener, inject, OnInit } from '@angular/core';
import { UserService } from './services/user.service';
import { CustomCookieService } from './services/cookie.service';
import { AuthenticationService } from './services/authentication.service';
import { Router } from '@angular/router';
import { MenuCustomService } from './services/menu-custom.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
  #authService = inject(AuthenticationService)
  #userService = inject(UserService)
  #cookieService = inject(CustomCookieService)
  #menuCustomService = inject(MenuCustomService)
  #translate = inject(TranslateService)

  router = inject(Router)

  ngOnInit(): void {
    this.#translate.setDefaultLang('fr')
    let token = this.#cookieService.retrieveToken()

    if (token) {
      this.#userService.setSpecificUser(token)
      this.#authService.acceptConnection()
    }
    else {
      this.#userService.setDefaultUser()
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