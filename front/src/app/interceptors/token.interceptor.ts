import { Injectable, inject } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { TokenService } from '../services/token.service';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {
  #tokenService = inject(TokenService)

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    let token = this.#tokenService.retrieveToken()

    if (token) {
      let clone = request.clone({
        setHeaders:
        {
          Authorization: `Bearer ${token}`
        }
      })

      return next.handle(clone)
    }

    return next.handle(request)
  }
}