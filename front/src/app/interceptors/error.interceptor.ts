// src/app/interceptors/error.interceptor.ts
import { Injectable, inject } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { NotificationService } from '../services/user-interface/notification.service';
import { LoggingService } from '../services/logging.service';
import { BaseResponse } from '../interfaces/http/base-response';
import { CustomError } from '../interfaces/error';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
  #notification = inject(NotificationService);
  #logger       = inject(LoggingService);

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse) => {
        let userMessage = 'Une erreur est survenue.';
        const body      = error.error as BaseResponse;
        const needV2    = (error.error as any).needV2 === true;

        if (error.error instanceof ErrorEvent) {
          userMessage = `Erreur réseau : ${error.error.message}`;
          this.#logger.error(error.error, 'Network');
        } else {
          if (body?.message) {
            userMessage = body.message;
            if (body.validationErrors?.length) {
              userMessage += ' — ' + body.validationErrors.join(', ');
            }
          } else {
            userMessage = `Erreur serveur (${error.status})`;
          }
          this.#logger.error(error, 'HTTP');
        }

        console.log('[Interceptor] needV2 =', needV2, 'message =', userMessage);

        if (!needV2) {
          this.#notification.error(userMessage, 'Erreur');
        }
        this.#logger.error(error, 'Interceptor');

        const enriched: CustomError = { original: error, needV2 };
        return throwError(() => enriched);
      })
    );
  }
}
