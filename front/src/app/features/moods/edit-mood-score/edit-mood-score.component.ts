import { Component, inject, Input } from '@angular/core';
import { MoodScoreUpdate } from '../../../interfaces/forms-update';
import { MoodFull } from '../../../interfaces/mood';
import { MoodService } from '../../../services/http/mood.service';

@Component({
  selector: 'app-edit-mood-score',
  templateUrl: './edit-mood-score.component.html',
  styleUrl: './edit-mood-score.component.scss'
})
export class EditMoodScoreComponent {
  #moodService = inject(MoodService)
  @Input() mood!: MoodFull

  public updateMoodScore(scoreValue: number): void {
    let form: MoodScoreUpdate = { moodId: this.mood.businessId, value: scoreValue }
    this.#moodService.updateMoodScore(form)
  }
}