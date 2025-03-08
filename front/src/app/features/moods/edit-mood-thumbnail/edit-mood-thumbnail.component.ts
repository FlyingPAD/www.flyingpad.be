import { Component, EventEmitter, Input, Output } from '@angular/core';
import { MoodFull } from '../../../interfaces/mood';

@Component({
  selector: 'app-edit-mood-thumbnail',
  templateUrl: './edit-mood-thumbnail.component.html',
  styleUrl: './edit-mood-thumbnail.component.scss'
})
export class EditMoodThumbnailComponent {
  @Input() mood!: MoodFull
  @Input() environment!: string

  @Output() toDetails = new EventEmitter<void>()

  public handleToDetails(): void {
    this.toDetails.emit()
  }
}