import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { PaginationService } from '../../../services/display/pagination.service';
import { FlowService } from '../../../services/flow.service';
import { MoodLight } from '../../../interfaces/mood';
import { MenuService } from '../../../services/display/menu.service';

@Component({
  selector: 'app-moods-gallery',
  templateUrl: './moods-gallery.component.html',
  styleUrl: './moods-gallery.component.scss'
})
export class MoodsGalleryComponent 
{
  #flowService = inject(FlowService)
  #menuService = inject(MenuService)
  paginationService = inject(PaginationService)

  @Input() moods : MoodLight[] | undefined = undefined
  @Output() moodId = new EventEmitter<number>()

  environment = environment.apiBaseUrl

  flow = this.#flowService.flow
  isRightMenuOn = this.#menuService.isRightMenuOn

  moodsPerPage:  number = 36      

  menuTrigger(): void {
    if(this.isRightMenuOn()) {
      this.#menuService.closeRightMenu()
    }
    else {
      this.#menuService.openRightMenu()
    }
  }

  handleMoodId(moodId: number): void {
    this.moodId.emit(moodId)
  }
}