import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { environment } from '../../environments/environment.prod';
import { RegisterCommandResponse, LoginQueryResponse } from '../models/authentication';
import { UserRegisterForm, UserLoginForm } from '../models/user';
import { UserService } from './user.service';
import { CustomCookieService } from './custom-cookie.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService 
{
  #http = inject(HttpClient)
  #url = environment.apiBaseUrl + '/api/V1/'
  #cookieService = inject(CustomCookieService)
  #userService = inject(UserService)


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
      })
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
      })
    )
  }

  // Logout
  // logout() : void 
  // {
  //   this.#cookieService.removeToken()
  //   this.#userService.setDefaultUser()
  //   this.closeConnection()  
  //   this.#toastr.success('You have been logged out !', 'Success !')
  // }

  // Update connection status to "connected"  
  public acceptConnection() : void { this.#isConnected.next(true) }

  // Update connection status to "disconnected"
  public closeConnection() : void { this.#isConnected.next(false) }
}