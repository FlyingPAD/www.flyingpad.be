import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { User, UserUpdateForm, UserUpdateResponse } from '../models/user';
import { jwtDecode } from 'jwt-decode';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  appUser!: User

  setDefaultUser() {
    this.appUser = {
      businessId: 0,
      created: new Date(),
      modified: new Date(),
      firstName: 'User',
      lastName: '',
      birthdate: new Date(),
      email: 'app@user.com',
      role: 0
    }
  }

  setSpecificUser(token: string): User {
    let user: User = jwtDecode(token)

    // Assure that role is treated as a number, matching the User model
    user.role = Number(user.role)

    this.appUser = user

    return user
  }

  public UpdateOneUser(form: UserUpdateForm): Observable<UserUpdateResponse> {
    return this.#http.put<UserUpdateResponse>(this.#url + "Users/Update/", form)
  }
}