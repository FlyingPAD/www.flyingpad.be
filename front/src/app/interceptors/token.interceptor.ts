import { Injectable, inject } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { CustomCookieService } from '../services/system/cookie.service';

@Injectable()
export class TokenInterceptor implements HttpInterceptor 
{
  #cookieService = inject(CustomCookieService)
  
  intercept(request : HttpRequest<unknown>, next : HttpHandler) : Observable<HttpEvent<unknown>> 
  {
    // Retrieve the JWT token from cookie

    let token = this.#cookieService.retrieveToken()

    // Check if the token exists

    if (token) 
    {
      // Clone the request to add the authorization header with the JWT token

      let clone = request.clone({
        setHeaders: 
        {
          Authorization: `Bearer ${token}`
        }
      })

      // Pass the cloned request instead of the original one
      
      return next.handle(clone)
    }

    // If no token is found, pass the original request without modification
    
    return next.handle(request)
  }
}