import { Component, EventEmitter, Input, Output, inject } from '@angular/core';
import { MoodLight } from '../../../models/mood';
import { environment } from '../../../../environments/environment';
import { PaginationService } from '../../../services/pagination.service';

@Component({
  selector: 'app-moods-gallery-flow',
  templateUrl: './moods-gallery-flow.component.html',
  styleUrl: './moods-gallery-flow.component.scss'
})
export class MoodsGalleryFlowComponent {
  paginationService = inject(PaginationService)
  @Input() moods : MoodLight[] | undefined = []
  @Output() moodId = new EventEmitter<number>();
  environment : string = environment.apiBaseUrl  
  moodsPerPage : number = 36  
  currentPage : number = 1

  handleMoodId(moodId : number) : void
  {
    this.moodId.emit(moodId)
  }
}