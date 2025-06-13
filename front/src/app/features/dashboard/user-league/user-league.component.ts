import { Component, inject, OnInit, OnDestroy } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { UserService } from '../../../services/http/user.service';
import { LeagueService } from '../../../services/http/league.service';
import { LeagueWithRankingDto, LeagueMemberDto } from '../../../interfaces/league';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-league',
  templateUrl: './user-league.component.html',
  styleUrls: ['./user-league.component.scss']
})
export class UserLeagueComponent implements OnInit, OnDestroy {
  #userService = inject(UserService)
  #leagueService = inject(LeagueService)
  #router = inject(Router)

  #destroy$ = new Subject<void>()

  public league: LeagueWithRankingDto | null = null
  public stayingMembers: LeagueMemberDto[] = []
  public promotedMembers: LeagueMemberDto[] = []

  ngOnInit(): void {
    const user = this.#userService.user()

    if (!user.league) {
      return
    }

    this.#leagueService.getLeagueByName(user.league.name)
      .pipe(takeUntil(this.#destroy$))
      .subscribe({
        next: league => {
          this.league = league;

          const threshold = league.maxExperience;
          this.promotedMembers = league.members
            .filter(m => m.seasonScore > threshold);

          this.stayingMembers = league.members
            .filter(m => m.seasonScore <= threshold);
        },
        error: err => console.error('Erreur chargement ligue', err)
      })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public goToUserProfile(userId: number): void {
    this.#userService.updatePublicUser(userId)
    this.#router.navigateByUrl('user-profile')
  }
}