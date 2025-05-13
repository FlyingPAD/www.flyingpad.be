import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { LeaderboardEntry } from '../../interfaces/leaderboard';
import { LeaderboardService } from '../../services/http/leaderboard.service';
import { Router } from '@angular/router';
import { UserService } from '../../services/http/user.service';
import { SeasonService } from '../../services/http/season.service';
import { Subject, takeUntil } from 'rxjs';
import { Season } from '../../interfaces/season';

@Component({
  selector: 'app-ladder',
  templateUrl: './ladder.component.html',
  styleUrl: './ladder.component.scss'
})
export class LadderComponent implements OnInit, OnDestroy {
  #userService = inject(UserService)
  #seasonService = inject(SeasonService)
  #leaderboardService = inject(LeaderboardService)
  #router = inject(Router)

  #destroy$ = new Subject<void>()

  public season?: Season
  public entries: LeaderboardEntry[] = []
  public loading = true
  public errorMsg?: string


  ngOnInit(): void {
    this.#leaderboardService.getLeaderboard()
    .pipe(takeUntil(this.#destroy$))
    .subscribe({
      next: data => {
        this.entries = data
        this.loading = false
      },
      error: () => {
        this.errorMsg = 'Impossible de charger le ladder.'
        this.loading = false
      }
    })

    this.#seasonService.getCurrentSeason()
    .pipe(takeUntil(this.#destroy$))
    .subscribe(response => this.season = response)
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }


  public goToUserProfile(userId: string): void {
    this.#userService.updatePublicUser(userId as unknown as number)
    this.#router.navigateByUrl('user-profile')
  }
}