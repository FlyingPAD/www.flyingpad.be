import { Injectable, inject } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';

@Injectable({
  providedIn: 'root'
})
export class CustomCookieService 
{
  #cookieService = inject(CookieService)
  
  storeToken( token: string ) : void 
  {
    this.#cookieService.set('authToken', token, 
    { 
      secure: true, 
      path: '/', 
      sameSite: 'Strict' 
    })
  }

  retrieveToken() : string | undefined 
  {
    const token = this.#cookieService.get('authToken')
    if (!token) return undefined
    return token
  }

  removeToken() : void
  {
    this.#cookieService.delete('authToken', '/', undefined, true, 'Strict')
  }
}