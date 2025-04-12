import { Component, EventEmitter, Input, Output } from '@angular/core';
import { MoodFull } from '../../../interfaces/mood';
import { environment } from '../../../../environments/environment';

@Component({
  selector: 'app-edit-mood-thumbnail',
  templateUrl: './edit-mood-thumbnail.component.html',
  styleUrl: './edit-mood-thumbnail.component.scss'
})
export class EditMoodThumbnailComponent {
  @Input() mood!: MoodFull
  @Output() backToGallery = new EventEmitter<void>()

  public environment = environment.apiBaseUrl

  public handleBackToGallery(): void {
    this.backToGallery.emit()
  }
}