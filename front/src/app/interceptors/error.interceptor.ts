import { Injectable, inject } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { NotificationService } from '../services/user-interface/notification.service';
import { BaseResponse } from '../interfaces/base-response';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
  #notificationService = inject(NotificationService)

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse) => {
        let errorMessage = 'An error occurred'

        if (error.error instanceof ErrorEvent) {
          // Client Error :
          errorMessage = `Client Error: ${error.error.message}`
        } 
        else {
          // Server Error :
          const serverResponse = error.error as BaseResponse

          if (serverResponse && typeof serverResponse.message === 'string') {
            errorMessage = serverResponse.message

            if (serverResponse.validationErrors && serverResponse.validationErrors.length) {
              errorMessage += ' - ' + serverResponse.validationErrors.join(', ')
            }
          } 
          else {
            // Fallback :
            errorMessage = `Server Error Status: ${error.status}, Message: ${error.message}`
          }
        }

        this.#notificationService.error(errorMessage, 'Server Error')
        return throwError(() => new Error(errorMessage))
      })
    )
  }
}