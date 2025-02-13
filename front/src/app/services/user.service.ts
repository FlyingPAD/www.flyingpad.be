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
    userName: 'Default User',
    firstName: 'John',
    lastName: 'Smith',
    birthdate: new Date(),
    email: 'user@app.com',
    role: 0,
    level: 0,
    experience: 0,
    achievements: []
  }
  #user = new BehaviorSubject<User>(this.DEFAULT_USER)
  public user = toSignal(this.#user) as Signal<User>

  public getUser(userId: number, role: number): Observable<User> {
    return this.#http.get<GetUserResponse>(`${this.#url}Users/GetUser/${userId}`).pipe(
      map(response => response.user),
      tap(user => {
        user.role = role
        user.achievements = [
          {
            id: 1,
            title: 'Official Member',
            goal: 'Create an account',
            done: 'You created an account :)',
            category: 'standard',
            date: new Date(),
            unlocked: true
          },
          // notes-bass
          {
            id: 2,
            title: 'Bass Novice',
            goal: 'Survive 10 seconds.',
            done: 'You lasted 10 sec. !!',
            category: 'notes-bass',
            date: undefined,
            unlocked: false
          },
          {
            id: 3,
            title: 'Bass Intermediate',
            goal: 'Survive 20 seconds.',
            done: 'You lasted 20 sec. !!',
            category: 'notes-bass',
            date: undefined,
            unlocked: false
          },
          {
            id: 4,
            title: 'Bass Advanced',
            goal: 'Survive 30 seconds.',
            done: 'You lasted 30 sec. !!',
            category: 'notes-bass',
            date: undefined,
            unlocked: false
          },
          {
            id: 5,
            title: 'Bass Expert',
            goal: 'Survive 40 seconds.',
            done: 'You lasted 40 sec. !!',
            category: 'notes-bass',
            date: undefined,
            unlocked: false
          },
          {
            id: 6,
            title: 'Bass Master',
            goal: 'Survive 50 seconds.',
            done: 'You lasted 50 sec. !!',
            category: 'notes-bass',
            date: undefined,
            unlocked: false
          },
          // notes-alto
          {
            id: 7,
            title: 'Alto Novice',
            goal: 'Survive 10 seconds.',
            done: 'You lasted 10 sec. !!',
            category: 'notes-alto',
            date: undefined,
            unlocked: false
          },
          {
            id: 8,
            title: 'Alto Intermediate',
            goal: 'Survive 20 seconds.',
            done: 'You lasted 20 sec. !!',
            category: 'notes-alto',
            date: undefined,
            unlocked: false
          },
          {
            id: 9,
            title: 'Alto Advanced',
            goal: 'Survive 30 seconds.',
            done: 'You lasted 30 sec. !!',
            category: 'notes-alto',
            date: undefined,
            unlocked: false
          },
          {
            id: 10,
            title: 'Alto Expert',
            goal: 'Survive 40 seconds.',
            done: 'You lasted 40 sec. !!',
            category: 'notes-alto',
            date: undefined,
            unlocked: false
          },
          {
            id: 11,
            title: 'Alto Master',
            goal: 'Survive 50 seconds.',
            done: 'You lasted 50 sec. !!',
            category: 'notes-alto',
            date: undefined,
            unlocked: false
          },
          // notes-treble
          {
            id: 12,
            title: 'Treble Novice',
            goal: 'Survive 10 seconds.',
            done: 'You lasted 10 sec. !!',
            category: 'notes-treble',
            date: undefined,
            unlocked: false
          },
          {
            id: 13,
            title: 'Treble Intermediate',
            goal: 'Survive 20 seconds.',
            done: 'You lasted 20 sec. !!',
            category: 'notes-treble',
            date: undefined,
            unlocked: false
          },
          {
            id: 14,
            title: 'Treble Advanced',
            goal: 'Survive 30 seconds.',
            done: 'You lasted 30 sec. !!',
            category: 'notes-treble',
            date: undefined,
            unlocked: false
          },
          {
            id: 15,
            title: 'Treble Expert',
            goal: 'Survive 40 seconds.',
            done: 'You lasted 40 sec. !!',
            category: 'notes-treble',
            date: undefined,
            unlocked: false
          },
          {
            id: 16,
            title: 'Treble Master',
            goal: 'Survive 50 seconds.',
            done: 'You lasted 50 sec. !!',
            category: 'notes-treble',
            date: undefined,
            unlocked: false
          }
        ]        
        this.#user.next(user)
      })
    )
  }

  public updatePlayerExperience(score: number): void {
    const user = this.user()
    if (user) {
      const updatedUser = { ...user, experience: user.experience + score }
      this.#user.next(updatedUser)
    }
  }

  public obtainAchievement(tableEntry: number): void {
    const user = this.user()
    if (user && tableEntry >= 0 && tableEntry < user.achievements.length) {
      const updatedAchievements = user.achievements.map((achievement, index) =>
        index === tableEntry ? { ...achievement, unlocked: true, date: new Date() } : achievement
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