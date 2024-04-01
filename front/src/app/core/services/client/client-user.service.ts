import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { User, UserUpdateForm, UserUpdateResponse } from '../../models/user';
import { jwtDecode } from 'jwt-decode';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  // Properties : 

  appUser = new User()

  // Methods :

  setDefaultUser()
  {
    this.appUser = 
    {
      businessId : 0,
      created : new Date(),
      modified : new Date(),
      firstName : 'Unregistered User',
      lastName : '',
      birthdate : new Date(),
      email : 'app@user.com',
      role : 0
    }
  }

  setSpecificUser( token : string ) : User
  {
    // Decode the JWT to extract user info

    let user : User = jwtDecode( token )

    // Assure that role is treated as a number, matching the User model

    user.role = Number( user.role )

    this.appUser = user

    return user
  }

  // - Get One User

  public GetOne( userId : number ) : Observable<User> | undefined 
  {
    return this.#http.get<User>(this.#url + 'Users/' + userId)
  }

  // - Update One User

  public UpdateOneUser( form : UserUpdateForm ) : Observable<UserUpdateResponse>
  {
    return this.#http.put<UserUpdateResponse>(this.#url + "Users/Update/", form)
  }
  
  // - Delete One User

  public Delete( userId : number ) : Observable<Boolean>
  {
    return this.#http.delete<Boolean>( this.#url + "Users/Update" + userId )
  }

}