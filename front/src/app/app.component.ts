import { Component, inject } from '@angular/core';
import { UserService } from './core/services/user.service';
import { CustomCookieService } from './core/services/cookie.service';
import { AuthService } from './core/services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent
{ 
  #authService = inject(AuthService)            // Authentication
  #userService = inject(UserService)            // User
  #cookieService = inject(CustomCookieService)  // Cookies

  ngOnInit() : void
  {
    // Token Check @ Startup / Refresh ( F5 )
    let token = this.#cookieService.retrieveToken()

    if(token)
    {
      this.#userService.setSpecificUser(token)
      this.#authService.acceptConnection()
    }
    else
    {
      this.#userService.setDefaultUser()
    }
  }
}