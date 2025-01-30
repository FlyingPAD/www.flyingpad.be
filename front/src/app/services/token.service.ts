import { inject, Injectable } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';
import { Token } from '../interfaces/token';
import { jwtDecode } from 'jwt-decode';

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  #cookieService = inject(CookieService)

  public storeToken(token: string): void {
    this.#cookieService.set('authToken', token,
      {
        secure: true,
        path: '/',
        sameSite: 'Strict'
      })
  }

  public retrieveToken(): string | null {
    return this.#cookieService.get('authToken')
  }

  public removeToken(): void {
    this.#cookieService.delete('authToken', '/', undefined, true, 'Strict')
  }

  public getUserIdFromToken(token: string): number {
    const decodedToken: Token = jwtDecode(token)
    return decodedToken.businessId
  }
  public getUserRoleFromToken(token: string): number {
    const decodedToken: Token = jwtDecode(token)
    return Number(decodedToken.role)
  }
}