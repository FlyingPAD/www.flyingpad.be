import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { PaginationService } from '../../../services/display/pagination.service';
import { MoodLight } from '../../../interfaces/mood';
import { MenuService } from '../../../services/display/menu.service';

@Component({
  selector: 'app-moods-gallery',
  templateUrl: './moods-gallery.component.html',
  styleUrl: './moods-gallery.component.scss'
})
export class MoodsGalleryComponent {
  #menuService = inject(MenuService)
  public paginationService = inject(PaginationService)

  @Input() moods : MoodLight[] | undefined = undefined
  @Output() moodId = new EventEmitter<number>()

  public environment = environment.apiBaseUrl
  public isRightMenuOn = this.#menuService.isRightMenuOn
  public moodsPerPage:  number = 36      

  public handleMoodId(moodId: number): void {
    this.moodId.emit(moodId)
  }
}