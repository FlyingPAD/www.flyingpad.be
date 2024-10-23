import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { PaginationService } from '../../../services/display/pagination.service';
import { FlowService } from '../../../services/flow.service';
import { MoodLight } from '../../../interfaces/mood';
import { RightColumnService } from '../../../services/display/right-column.service';

@Component({
  selector: 'app-moods-gallery',
  templateUrl: './moods-gallery.component.html',
  styleUrl: './moods-gallery.component.scss'
})
export class MoodsGalleryComponent 
{
  #flowService = inject(FlowService)
  rightColumnService = inject(RightColumnService)
  paginationService = inject(PaginationService)

  @Input() moods : MoodLight[] | undefined = undefined
  @Output() moodId = new EventEmitter<number>()

  environment = environment.apiBaseUrl

  flow = this.#flowService.flow
  rightColumnIsActive = this.rightColumnService.rightColumnIsActive

  moodsPerPage:  number = 36      

  menuTrigger(): void {
    if(this.rightColumnIsActive()) {
      this.rightColumnService.disableRightColumn()
    }
    else {
      this.rightColumnService.enableRightColumn()
    }
  }

  handleMoodId(moodId: number): void {
    this.moodId.emit(moodId)
  }
}