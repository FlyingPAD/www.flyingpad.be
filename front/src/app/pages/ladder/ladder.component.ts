import { Component, inject, OnInit } from '@angular/core';
import { LeaderboardEntry } from '../../interfaces/leaderboard';
import { LeaderboardService } from '../../services/http/leaderboard.service';
import { Router } from '@angular/router';
import { UserService } from '../../services/http/user.service';

@Component({
  selector: 'app-ladder',
  templateUrl: './ladder.component.html',
  styleUrl: './ladder.component.scss'
})
export class LadderComponent implements OnInit {  
  #userService = inject(UserService)
  #router = inject(Router);
  entries: LeaderboardEntry[] = [];
  loading = true;
  errorMsg?: string;

  constructor(private leaderboardService: LeaderboardService) {}

  ngOnInit(): void {
    this.leaderboardService.getLeaderboard().subscribe({
      next: data => {
        this.entries = data;
        this.loading = false;
      },
      error: () => {
        this.errorMsg = 'Impossible de charger le ladder.';
        this.loading = false;
      }
    })
  }

  public goToUserProfile(userId: string): void {
    this.#userService.updatePublicUser(userId as unknown as number)
    this.#router.navigateByUrl('user-profile')
  }
}