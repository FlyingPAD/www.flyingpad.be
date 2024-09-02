import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { UserRegisterForm, UserLoginForm } from '../models/user';
import { ToastrService } from 'ngx-toastr';
import { LoginQueryResponse, RegisterCommandResponse } from '../models/auth';
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

  public register( form : UserRegisterForm ) : Observable<RegisterCommandResponse> {
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

  public login( form : UserLoginForm ) : Observable<LoginQueryResponse> {
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

  logout(): void {
    this.#cookieService.removeToken()
    this.#userService.setDefaultUser()
    this.closeConnection()  
    this.#toastr.success('You have been logged out !', 'Success !')
  }

  public acceptConnection() : void { this.#isConnected.next(true) }

  public closeConnection() : void { this.#isConnected.next(false) }


  #handleError = (error : HttpErrorResponse) => {
    let errorMessage = 'An unexpected error occurred.'

    if (error.error instanceof ErrorEvent) {
      errorMessage = `Client error: ${error.error.message}`
    } 
    else {
      errorMessage = `Server error (${error.status}): ${error.statusText}`
    }
    this.#toastr.error(errorMessage, 'Error')

    return throwError(() => new Error(errorMessage))
  }
}