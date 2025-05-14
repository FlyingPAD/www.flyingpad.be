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
  public daysLeft?: number
  public entriesByLeague: { leagueName: string; entries: LeaderboardEntry[] }[] = []


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
      })

    this.#seasonService.getCurrentSeason()
      .pipe(takeUntil(this.#destroy$))
      .subscribe(response => {
        this.season = response
        this.computeDaysLeft()
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
    this.daysLeft = Math.ceil((end - now) / (1000 * 60 * 60 * 24));
  }

  private groupEntries(): void {
    const map = new Map<string, LeaderboardEntry[]>();
    for (const e of this.entries) {
      if (!map.has(e.leagueName)) map.set(e.leagueName, [])
      map.get(e.leagueName)!.push(e)
    }
    this.entriesByLeague = Array.from(map.entries()).map(([leagueName, list]) => ({
      leagueName,
      entries: list.sort((a, b) => b.seasonScore - a.seasonScore)
    }))
  }

  public goToUserProfile(userId: string): void {
    this.#userService.updatePublicUser(userId as unknown as number)
    this.#router.navigateByUrl('user-profile')
  }
}