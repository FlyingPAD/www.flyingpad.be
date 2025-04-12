import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-edit-mood-score',
  templateUrl: './edit-mood-score.component.html',
  styleUrl: './edit-mood-score.component.scss'
})
export class EditMoodScoreComponent {
  @Input() moodScore!: number

  @Output() updateMoodScore = new EventEmitter<number>()

  public handleUpdateMoodScore(scoreValue: number): void {
    this.updateMoodScore.emit(scoreValue)
  }
}