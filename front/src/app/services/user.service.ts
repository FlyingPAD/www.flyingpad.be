import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { User, UserUpdateForm, UserUpdateResponse } from '../interfaces/user';
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
      pseudonym: 'Default User',
      firstName: 'User',
      lastName: '',
      birthdate: new Date(),
      email: 'app@user.com',
      role: 0,
      level: 1,
      experience : 0,
      achievements: [
        { id: 1, name: 'member', isTrue: true },
        { id: 2, name: 'lasted 10 seconds', isTrue: false },
        { id: 3, name: 'lasted 20 seconds', isTrue: false },
        { id: 4, name: 'lasted 30 seconds', isTrue: false },
        { id: 5, name: 'lasted 40 seconds', isTrue: false },
        { id: 6, name: 'lasted 50 seconds', isTrue: false },
      ]
    }
  }

  setSpecificUser(token: string): User {
    let user: User = jwtDecode(token)

    // Assure that role is treated as a number, matching the User model
    user.role = Number(user.role)

    this.appUser = user
    this.initUser(this.appUser)

    return user
  }

  public UpdateOneUser(form: UserUpdateForm): Observable<UserUpdateResponse> {
    return this.#http.put<UserUpdateResponse>(this.#url + "Users/Update/", form)
  }

  public updatePlayerExperience(score: number): void {
    this.appUser.experience += score
  }

  public obtainAchievement(tableEntry: number): void {
    this.appUser.achievements[tableEntry].isTrue = true
  }

  private initUser(user: User): void {
    user.level = 1
    user.experience = 0
    user.achievements = [
      { id: 1, name: 'member', isTrue: true },
      { id: 2, name: 'lasted 10 seconds', isTrue: false },
      { id: 3, name: 'lasted 20 seconds', isTrue: false },
      { id: 4, name: 'lasted 30 seconds', isTrue: false },
      { id: 5, name: 'lasted 40 seconds', isTrue: false },
      { id: 6, name: 'lasted 50 seconds', isTrue: false },
    ]
  }
}