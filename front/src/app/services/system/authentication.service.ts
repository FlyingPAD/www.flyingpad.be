import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { UserRegisterForm, UserLoginForm } from '../../interfaces/user';
import { ToastrService } from 'ngx-toastr';
import { LoginQueryResponse, RegisterCommandResponse } from '../../interfaces/authentication';
import { environment } from '../../../environments/environment';
import { CustomCookieService } from './cookie.service';
import { UserService } from '../user.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  #http = inject(HttpClient)
  #toastr = inject(ToastrService)
  #cookieService = inject(CustomCookieService)
  #userService = inject(UserService)

  #url = environment.apiBaseUrl + '/api/V1/'

  #isConnected = new BehaviorSubject<boolean>(false)
  public acceptConnection(): void { this.#isConnected.next(true) }
  public closeConnection(): void { this.#isConnected.next(false) }
  isConnectedSub: Observable<boolean> = this.#isConnected.asObservable()

  public register(form: UserRegisterForm): Observable<RegisterCommandResponse> {
    return this.#http.post<RegisterCommandResponse>(`${this.#url}Auth/Register`, form).pipe(
      tap(response => {
        if(response.success) {
          this.#cookieService.storeToken(response.token)
          this.#userService.setSpecificUser(response.token)
          this.acceptConnection()
          this.#toastr.success(response.message)
        }       
        else this.#toastr.error(response.message)
      }))
  }
  public login(form: UserLoginForm): Observable<LoginQueryResponse> {
    return this.#http.post<LoginQueryResponse>(`${this.#url}Auth/Login`, form).pipe(
      tap(response => {
        if(response.success) {
          this.#cookieService.storeToken(response.token)
          this.#userService.setSpecificUser(response.token)
          this.acceptConnection()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  logout(): void {
    this.#cookieService.removeToken()
    this.#userService.setDefaultUser()
    this.closeConnection()  
    this.#toastr.success('See you soon.')
  }
}