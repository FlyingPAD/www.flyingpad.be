import { HttpClient } from '@angular/common/http';
import { Injectable, Signal, inject } from '@angular/core';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { ToastrService } from 'ngx-toastr';
import { LoginQueryResponse, RegisterCommandResponse, UserLoginForm, UserRegisterForm } from '../interfaces/authentication';
import { environment } from '../../environments/environment';
import { UserService } from './user.service';
import { toSignal } from '@angular/core/rxjs-interop';
import { TokenService } from './token.service';
import { RedirectionService } from './redirection.service';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  #http = inject(HttpClient)
  #toastr = inject(ToastrService)
  #tokenService = inject(TokenService)
  #userService = inject(UserService)
  #redirectionService = inject(RedirectionService)
  #router = inject(Router)

  #url = environment.apiBaseUrl + '/api/V1/'
  #isConnected = new BehaviorSubject<boolean>(false)
  public isConnected = toSignal(this.#isConnected) as Signal<boolean>

  public login(form: UserLoginForm): Observable<LoginQueryResponse> {
    return this.#http.post<LoginQueryResponse>(`${this.#url}Auth/Login`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#tokenService.storeToken(response.token)
          this.authenticate(response.token)
          this.#toastr.success(response.message)
        } else {
          this.#toastr.error(response.message)
          this.#router.navigateByUrl('log-in/error')
        }
      }),
      catchError(error => {
        this.#router.navigateByUrl('log-in/error')        
        return throwError(() => error)
      })
    )
  }

  public register(form: UserRegisterForm): Observable<RegisterCommandResponse> {
    return this.#http.post<RegisterCommandResponse>(`${this.#url}Auth/Register`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#tokenService.storeToken(response.token)
          this.authenticate(response.token)
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }

  public logout(): void {
    this.#tokenService.removeToken()
    this.#userService.setDefaultUser()
    this.closeConnection()
    this.#toastr.success('See you soon.')
  }

  public acceptConnection(): void {
    this.#isConnected.next(true)
  }
  public closeConnection(): void {
    this.#isConnected.next(false)
  }

  public authenticate(token: string): void {
    let userId = this.#tokenService.getUserIdFromToken(token)
    let role = this.#tokenService.getUserRoleFromToken(token)
    this.#userService.getUser(userId, role).subscribe()
    this.acceptConnection()
    this.#redirectionService.redirect(role)
  }
}