import { Component, inject, OnDestroy, OnInit } from '@angular/core';
import { interval, Subject, takeUntil } from 'rxjs';
import { LeaderboardEntry } from '../../interfaces/leaderboard';
import { Season } from '../../interfaces/season';
import { LeaderboardService } from '../../services/http/leaderboard.service';
import { SeasonService } from '../../services/http/season.service';
import { UserService } from '../../services/http/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ladder',
  templateUrl: './ladder.component.html',
  styleUrls: ['./ladder.component.scss']
})
export class LadderComponent implements OnInit, OnDestroy {
  #userService = inject(UserService)
  #seasonService = inject(SeasonService)
  #leaderboardService = inject(LeaderboardService)
  #router = inject(Router)

  #destroy$ = new Subject<void>()

  public season?: Season
  public entries: LeaderboardEntry[] = []
  public entriesByLeague: { leagueName: string; entries: LeaderboardEntry[] }[] = []
  public loading = true
  public errorMsg?: string

  public daysLeft?: number
  public remainingDays = 0
  public remainingHours = 0
  public remainingMinutes = 0
  public remainingSeconds = 0

  ngOnInit(): void {
    this.#leaderboardService.getLeaderboard()
      .pipe(takeUntil(this.#destroy$))
      .subscribe({
        next: data => {
          this.entries = data
          this.groupEntries()
          this.loading = false
        },
        error: () => {
          this.errorMsg = 'Impossible de charger le ladder.'
          this.loading = false
        }
      });

    this.#seasonService.getCurrentSeason()
      .pipe(takeUntil(this.#destroy$))
      .subscribe(response => {
        this.season = response
        this.computeDaysLeft()
        this.startCountdown()
      })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private computeDaysLeft(): void {
    if (!this.season?.endsAt) {
      this.daysLeft = undefined
      return
    }
    const now = Date.now()
    const end = new Date(this.season.endsAt).getTime()
    this.daysLeft = Math.ceil((end - now) / (1000 * 60 * 60 * 24))
  }

  private startCountdown(): void {
    if (!this.season?.endsAt) {
      return
    }

    interval(1000)
      .pipe(takeUntil(this.#destroy$))
      .subscribe(() => {
        const now = Date.now()
        const end = new Date(this.season!.endsAt).getTime()
        let diff = end - now

        if (diff <= 0) {
          this.remainingDays = this.remainingHours = this.remainingMinutes = this.remainingSeconds = 0
          return
        }

        this.remainingDays = Math.floor(diff / (1000 * 60 * 60 * 24))
        diff -= this.remainingDays * 1000 * 60 * 60 * 24

        this.remainingHours = Math.floor(diff / (1000 * 60 * 60))
        diff -= this.remainingHours * 1000 * 60 * 60

        this.remainingMinutes = Math.floor(diff / (1000 * 60))
        diff -= this.remainingMinutes * 1000 * 60

        this.remainingSeconds = Math.floor(diff / 1000)
      });
  }

  private groupEntries(): void {
    const map = new Map<string, LeaderboardEntry[]>();
    for (const e of this.entries) {
      if (!map.has(e.leagueName)) {
        map.set(e.leagueName, [])
      }
      map.get(e.leagueName)!.push(e)
    }
    this.entriesByLeague = Array.from(map.entries()).map(([leagueName, list]) => ({
      leagueName,
      entries: list.sort((a, b) => b.seasonScore - a.seasonScore)
    }))
  }

  public goToUserProfile(userId: number): void {
    this.#userService.updatePublicUser(userId)
    this.#router.navigateByUrl('user-profile')
  }
}