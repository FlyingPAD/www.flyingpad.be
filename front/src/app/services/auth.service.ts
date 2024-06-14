import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { UserRegisterForm, UserLoginForm } from '../core/models/user';
import { ToastrService } from 'ngx-toastr';
import { LoginQueryResponse, RegisterCommandResponse } from '../core/models/auth';
import { environment } from '../../environments/environment';
import { CustomCookieService } from './cookie.service';
import { UserService } from './user.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService 
{
  #http = inject(HttpClient)
  #toastr = inject(ToastrService)
  #cookieService = inject(CustomCookieService)
  #userService = inject(UserService)

  #url = environment.apiBaseUrl + '/api/V1/'

  #isConnected = new BehaviorSubject<Boolean>(false)
  isConnectedSub: Observable<Boolean> = this.#isConnected.asObservable()

  // Register
  public register( form : UserRegisterForm ) : Observable<RegisterCommandResponse> 
  {
    return this.#http.post<RegisterCommandResponse>(`${this.#url}Auth/Register`, form).pipe(
      tap(response => 
      {       
        this.#cookieService.storeToken(response.token)
        this.#userService.setSpecificUser(response.token)
        this.acceptConnection()
        this.#toastr.success('Registration successful.', 'Success')
      }),
      catchError(this.#handleError)
    )
  }

  // Login
  public login( form : UserLoginForm ) : Observable<LoginQueryResponse> 
  {
    return this.#http.post<LoginQueryResponse>(`${this.#url}Auth/Login`, form).pipe(
      tap(response => 
      {
        this.#cookieService.storeToken(response.token)
        this.#userService.setSpecificUser(response.token)
        this.acceptConnection()
        this.#toastr.success('Login successful !', 'Success !')
      }),
      catchError(this.#handleError)
    )
  }

  // Logout
  logout() : void 
  {
    this.#cookieService.removeToken()
    this.#userService.setDefaultUser()
    this.closeConnection()  
    this.#toastr.success('You have been logged out !', 'Success !')
  }

  // Update connection status to "connected"  
  public acceptConnection() : void { this.#isConnected.next(true) }

  // Update connection status to "disconnected"
  public closeConnection() : void { this.#isConnected.next(false) }


  // Generic error handling method
  #handleError = (error : HttpErrorResponse) => 
  {
    let errorMessage = 'An unexpected error occurred.'

    if (error.error instanceof ErrorEvent) 
    {
      // Client-side or network error occurred, handle it accordingly
      errorMessage = `Client error: ${error.error.message}`
    } 
    else 
    {
      // The backend returned an unsuccessful response code
      errorMessage = `Server error (${error.status}): ${error.statusText}`
    }
    // Display the error message using toastr for all errors
    this.#toastr.error(errorMessage, 'Error')

    // Return an observable with a user-facing error message
    return throwError(() => new Error(errorMessage))
  }
}