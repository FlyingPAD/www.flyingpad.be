import { HttpClient } from '@angular/common/http';
import { Injectable, Signal, inject } from '@angular/core';
import { BehaviorSubject, map, Observable, tap } from 'rxjs';
import { GetAllUsersResponse, GetUserResponse, User, UserUpdateResponse } from '../../interfaces/user';
import { GetUserAchievementsResponse, NewAchievement } from '../../interfaces/achievement';
import { environment } from '../../../environments/environment';
import { ToastrService } from 'ngx-toastr';
import { UserUpdateForm } from '../../interfaces/http/forms-update';
import { toSignal } from '@angular/core/rxjs-interop';
import { BaseResponse } from '../../interfaces/http/base-response';

@Injectable({ providedIn: 'root' })
export class UserService {
  #http = inject(HttpClient)
  #toastr = inject(ToastrService)
  #url = environment.apiBaseUrl + '/api/V1/'

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
    seasonScore: 0,
    achievements: [],
    isEmailVerified: false
  };

  #user = new BehaviorSubject<User>(this.DEFAULT_USER)
  public user: Signal<User> = toSignal(this.#user, { initialValue: this.DEFAULT_USER })

  #publicUser = new BehaviorSubject<User>(this.DEFAULT_USER)
  public publicUser: Signal<User> = toSignal(this.#publicUser, { initialValue: this.DEFAULT_USER })

  public updatePublicUser(userId: number): void {
    this.getPublicUserById(userId).subscribe()
  }

  #achievements = new BehaviorSubject<NewAchievement[]>([]);
  public achievements: Signal<NewAchievement[]> = toSignal(this.#achievements, {
    initialValue: []
  })

  private refreshUser(): void {
    const biz = this.user().businessId;
    const role = this.user().role;
    this.getUser(biz, role).subscribe();
    this.getUserAchievements(biz).subscribe();
  }

  public getUser(userBusinessId: number, role: number): Observable<User> {
    return this.#http.get<GetUserResponse>(`${this.#url}Users/GetUser/${userBusinessId}`).pipe(
      map(resp => resp.user),
      tap(u => {
        u.role = role
        this.#user.next(u)
      })
    )
  }

  public getPublicUserById(userBusinessId: number): Observable<User> {
    return this.#http.get<GetUserResponse>(`${this.#url}Users/GetUser/${userBusinessId}`).pipe(
      map(resp => resp.user),
      tap(u => {
        this.#publicUser.next(u)
      })
    )
  }

  public getUserAchievements( userBusinessId: number): Observable<NewAchievement[]> {
    return this.#http.get<GetUserAchievementsResponse>(`${this.#url}Users/${userBusinessId}/Achievements`).pipe(
      map(resp => resp.achievements),
      tap(list => this.#achievements.next(list))
    )
  }

  public unlockAchievement(userBusinessId: number, achievementBusinessId: number): Observable<BaseResponse> {
    return this.#http.post<BaseResponse>(`${this.#url}Users/UnlockAchievement`, { userBusinessId, achievementBusinessId }).pipe(tap(() => this.refreshUser()))
  }

  public unlockAchievements(userBusinessId: number, achievementBusinessIds: number[]): Observable<BaseResponse> {
    return this.#http.post<BaseResponse>(`${this.#url}Users/UnlockAchievements`, { userBusinessId, achievementBusinessIds }).pipe(tap(() => this.refreshUser()))
  }

  public gainExperience(userBusinessId: number, xp: number): Observable<BaseResponse> {
    return this.#http.post<BaseResponse>(`${this.#url}Users/GainExperience`, { userBusinessId: userBusinessId, xp }).pipe(
      tap(() => {
        const biz = this.user().businessId;
        const role = this.user().role;
        this.getUser(biz, role).subscribe();
      })
    )
  }

  public gainSeasonScore(userBusinessId: number, score: number): Observable<BaseResponse> {
    return this.#http.post<BaseResponse>(`${this.#url}Users/GainSeasonScore`, { userBusinessId: userBusinessId, score }).pipe(
      tap(() => {
        const biz = this.user().businessId;
        const role = this.user().role;
        this.getUser(biz, role).subscribe();
      })
    )
  }

  public updateUser(form: UserUpdateForm): Observable<UserUpdateResponse> {
    return this.#http.put<UserUpdateResponse>(`${this.#url}Users/Update/`, form).pipe(
      tap(resp => {
        const u = { ...this.user(), ...resp.updatedUser };
        this.#user.next(u);
        this.#toastr.success(resp.message);
      })
    )
  }

  public setDefaultUser(): void {
    this.#user.next(this.DEFAULT_USER);
  }

  public getAllUsers(): Observable<User[]> {
    return this.#http.get<GetAllUsersResponse>(`${this.#url}Users/GetAll`).pipe(map(response => response.users))
  }
}