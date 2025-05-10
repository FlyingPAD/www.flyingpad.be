import { Component, inject } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { User } from '../../interfaces/user';
import { UserService } from '../../services/http/user.service';

@Component({
  selector: 'app-user-league',
  templateUrl: './user-league.component.html',
  styleUrl: './user-league.component.scss'
})
export class UserLeagueComponent {
  #userService = inject(UserService)

  #destroy$ = new Subject<void>()

  public user = this.#userService.user
  public users : User[] = []

  ngOnInit(): void {
    this.#userService.getAllUsers()
    .pipe(takeUntil(this.#destroy$))
    .subscribe(response => this.users = response)  
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }
}