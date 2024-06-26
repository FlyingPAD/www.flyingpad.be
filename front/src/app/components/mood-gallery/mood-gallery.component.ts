import { Component, EventEmitter, Input, Output, inject } from '@angular/core';
import { MoodLight } from '../../models/mood';
import { environment } from '../../../environments/environment';
import { PaginationService } from '../../services/pagination.service';

@Component({
  selector: 'app-mood-gallery',
  templateUrl: './mood-gallery.component.html',
  styleUrl: './mood-gallery.component.scss'
})
export class MoodGalleryComponent {
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