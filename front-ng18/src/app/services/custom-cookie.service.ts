import { Injectable, inject } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';

@Injectable({
  providedIn: 'root'
})
export class CustomCookieService 
{
  #cookieService = inject(CookieService)
  
  // Store token in a secured cookie

  storeToken( token: string ) : void 
  {
    this.#cookieService.set('authToken', token, 
    { 
      secure: true, 
      path: '/', 
      sameSite: 'Strict' 
    })
  }

  // Retrieve Token from cookie

  retrieveToken(): string | null 
  {
    return this.#cookieService.get('authToken')
  }

  // Delete token from cookie

  removeToken() : void
  {
    this.#cookieService.delete('authToken', '/', undefined, true, 'Strict')
  }
}