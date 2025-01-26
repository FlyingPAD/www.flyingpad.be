import { Component, Input } from '@angular/core';
import { MoodFull } from '../../../interfaces/mood';

@Component({
  selector: 'app-edit-mood-thumbnail',
  templateUrl: './edit-mood-thumbnail.component.html',
  styleUrl: './edit-mood-thumbnail.component.scss'
})
export class EditMoodThumbnailComponent {
  @Input() mood!: MoodFull
  @Input() environment!: string
}