import { Component, EventEmitter, Input, Output } from '@angular/core';
import { MoodLight } from '../../../models/mood';
import { environment } from '../../../../environments/environment';

@Component({
  selector: 'app-moods-gallery-flow',
  templateUrl: './moods-gallery-flow.component.html',
  styleUrl: './moods-gallery-flow.component.scss'
})
export class MoodsGalleryFlowComponent {
  @Input() moods : MoodLight[] | undefined = []
  @Output() moodId = new EventEmitter<number>()

  environment : string = environment.apiBaseUrl  

  currentMoodId : number = 0

  moodsPerPage : number = 36  
  currentPage : number = 1

  handleMoodId(moodId : number) : void
  {
    this.currentMoodId = moodId
    this.moodId.emit(moodId)
  }
}