import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { NewAchievement } from '../../../interfaces/achievement';
import { UserService } from '../../../services/http/user.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-achievements',
  templateUrl: './achievements.component.html',
  styleUrls: ['./achievements.component.scss']
})
export class AchievementsComponent implements OnInit, OnDestroy {
  #userService = inject(UserService)

  #destroy$ = new Subject<void>()

  public user = this.#userService.user
  public achievements: NewAchievement[] = []
  public grouped: { category: string; items: NewAchievement[] }[] = []

  public currentAchievement!: NewAchievement


  ngOnInit(): void {
    const bizId = this.#userService.user().businessId;
    if (!bizId) return;

    this.#userService.getUserAchievements(bizId)
      .pipe(takeUntil(this.#destroy$))
      .subscribe(list => {
        this.achievements = list
        this.grouped = Object.entries(
          list.reduce((acc, ach) => {
            (acc[ach.category] ||= []).push(ach)
            return acc;
          }, {} as Record<string, NewAchievement[]>)
        )
          .map(([category, items]) => ({ category, items }))
      })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }


  public displayAchievement(ach: NewAchievement) {
    this.currentAchievement = ach
  }

  public titleFor(category: string): string {
    switch (category) {
      case 'standard': return 'Achievements';
      case 'notes-bass': return 'Bass Clef';
      case 'notes-alto': return 'Alto Clef';
      case 'notes-treble': return 'Treble Clef';
      default: return category.charAt(0).toUpperCase() + category.slice(1);
    }
  }
}