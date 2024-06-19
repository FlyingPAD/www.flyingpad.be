import { Injectable, inject } from '@angular/core';
import { User, UserUpdateForm, UserUpdateResponse } from '../models/user';
import { jwtDecode } from 'jwt-decode';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class UserService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  appUser : User | undefined = undefined


  setUser( token : string ) : User
  {
    // Decode the JWT to extract user info.
    let user : User = jwtDecode( token )

    // Assure that role is treated as a number, matching the User model.
    user.role = Number( user.role )

    this.appUser = user

    return user
  }

  removeUser()
  {
    this.appUser = undefined
  }

  public GetOne( userId : number ) : Observable<User> | undefined 
  {
    return this.#http.get<User>(this.#url + 'Users/' + userId)
  }

  public UpdateOneUser( form : UserUpdateForm ) : Observable<UserUpdateResponse>
  {
    return this.#http.put<UserUpdateResponse>(this.#url + "Users/Update/", form)
  }
  
  public Delete( userId : number ) : Observable<Boolean>
  {
    return this.#http.delete<Boolean>( this.#url + "Users/Update" + userId )
  }
}