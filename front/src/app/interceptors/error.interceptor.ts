import { Injectable, inject } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HttpErrorResponse } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
  toastr = inject(ToastrService)

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse) => {
        let errorMsg = 'An error occurred'

        if (error.error instanceof ErrorEvent) {
          // Client-side error
          errorMsg = `Client Error: ${error.error.message}`
        }
        else {
          // Server-side error
          errorMsg = `Server Error Status: ${error.status}, Message: ${error.message}`
        }
        this.toastr.error(errorMsg, 'server Error')

        return throwError(() => new Error(errorMsg))
      })
    )
  }
}