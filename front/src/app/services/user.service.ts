import { HttpClient } from '@angular/common/http';
import { Injectable, Signal, inject } from '@angular/core';
import { BehaviorSubject, map, Observable, tap } from 'rxjs';
import { GetUserResponse, User, UserUpdateResponse } from '../interfaces/user';
import { environment } from '../../environments/environment';
import { ToastrService } from 'ngx-toastr';
import { UserUpdateForm } from '../interfaces/forms-update';
import { toSignal } from '@angular/core/rxjs-interop';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  #http = inject(HttpClient)
  #toastr = inject(ToastrService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  private readonly DEFAULT_USER: User = {
    businessId: 0,
    created: new Date(),
    modified: new Date(),
    pseudonym: 'Default User',
    firstName: 'John',
    lastName: 'Smith',
    birthdate: new Date(),
    email: 'user@app.com',
    role: 0,
    level: 1,
    experience: 0,
    achievements: []
  }
  #user = new BehaviorSubject<User>(this.DEFAULT_USER)
  public user = toSignal(this.#user) as Signal<User>

  public getUser(userId: number, role: number): Observable<User> {
    return this.#http.get<GetUserResponse>(`${this.#url}Users/GetUser/${userId}`).pipe(
      map(response => response.user),
      tap(user => {
        user.level = 1
        user.role = role
        user.experience = 0
        user.achievements = [
          { id: 1, name: 'Member', isTrue: true },
          { id: 2, name: 'Lasted 10 seconds', isTrue: false },
          { id: 3, name: 'Lasted 20 seconds', isTrue: false },
          { id: 4, name: 'Lasted 30 seconds', isTrue: false },
          { id: 5, name: 'Lasted 40 seconds', isTrue: false },
          { id: 6, name: 'Lasted 50 seconds', isTrue: false },
        ]
        this.#user.next(user)
      })
    )
  }

  public updatePlayerExperience(score: number): void {
    const user = this.user();
    if (user) {
      const updatedUser = { ...user, experience: user.experience + score }
      this.#user.next(updatedUser)
    }
  }

  public obtainAchievement(tableEntry: number): void {
    const user = this.user();
    if (user && tableEntry >= 0 && tableEntry < user.achievements.length) {
      const updatedAchievements = user.achievements.map((achievement, index) =>
        index === tableEntry ? { ...achievement, isTrue: true } : achievement
      )
      this.#user.next({ ...user, achievements: updatedAchievements })
    }
  }

  public updateUser(form: UserUpdateForm): Observable<UserUpdateResponse> {
    return this.#http.put<UserUpdateResponse>(`${this.#url}Users/Update/`, form).pipe(
      tap(response => {
        const updatedUser = { ...this.user(), ...response.updatedUser }
        this.#user.next(updatedUser)
        this.#toastr.success(response.message)
      })
    )
  }

  public setDefaultUser(): void {
    this.#user.next(this.DEFAULT_USER)
  }
}