import { Component, inject, Input } from '@angular/core';
import { MoodScoreUpdate } from '../../../interfaces/forms-update';
import { FlowService } from '../../../services/flow.service';
import { MoodFull } from '../../../interfaces/mood';

@Component({
  selector: 'app-edit-mood-score',
  templateUrl: './edit-mood-score.component.html',
  styleUrl: './edit-mood-score.component.scss'
})
export class EditMoodScoreComponent {
  #flowService = inject(FlowService)
  @Input() mood!: MoodFull

  public updateMoodScore(scoreValue: number): void {
    let form: MoodScoreUpdate = { moodId: this.mood.businessId, value: scoreValue }
    this.#flowService.updateScore(form)
  }
}