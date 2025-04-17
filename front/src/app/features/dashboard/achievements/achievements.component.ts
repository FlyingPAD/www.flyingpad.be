import { Component, inject, Input } from '@angular/core';
import { Achievement } from '../../../interfaces/achievement';
import { Router } from '@angular/router';
import { ToolsService } from '../../../services/user-interface/tools.service';
import { ToolsViewMode } from '../../../enumerations/view-modes';

@Component({
  selector: 'app-achievements',
  templateUrl: './achievements.component.html',
  styleUrl: './achievements.component.scss'
})
export class AchievementsComponent {
  #toolsService = inject(ToolsService)
  #router = inject(Router)

  @Input() achievements: Achievement[] = []

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

  public GoToNotesTrainer(): void {
    this.#toolsService.setToolsViewMode(ToolsViewMode.NotesTrainer)
    this.#router.navigateByUrl('/tools')
  }
}