import { Component, Input } from '@angular/core';
import { Achievement } from '../../../interfaces/achievement';

@Component({
  selector: 'app-achievements',
  templateUrl: './achievements.component.html',
  styleUrl: './achievements.component.scss'
})
export class AchievementsComponent {
  @Input() achievements : Achievement[] = []
}