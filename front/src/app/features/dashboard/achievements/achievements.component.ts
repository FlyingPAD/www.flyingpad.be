import { Component, Input } from '@angular/core';
import { Achievement } from '../../../interfaces/achievement';

@Component({
  selector: 'app-achievements',
  templateUrl: './achievements.component.html',
  styleUrl: './achievements.component.scss'
})
export class AchievementsComponent {
  @Input() achievements : Achievement[] = []

  public currentAchievement!: Achievement
  public isDialogOpen: boolean = false

  public toggleDialog(): void {
    this.isDialogOpen = !this.isDialogOpen
  }

  public setAchievement(achievement: Achievement): void {
    this.currentAchievement = achievement
  }

  public displayAchievement(achievement: Achievement): void {
    this.setAchievement(achievement)
    this.toggleDialog()
  }
}