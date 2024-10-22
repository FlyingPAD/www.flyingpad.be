import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { FlowService } from '../../../services/flow.service';
import { MenuDesktopService } from '../../../services/menu-desktop.service';
import { MultiTagService } from '../../../services/multi-tag.service';
import { PaginationService } from '../../../services/pagination.service';
import { MoodLight } from '../../../interfaces/mood';

@Component({
  selector: 'app-multi-tag',
  templateUrl: './multi-tag.component.html',
  styleUrl: './multi-tag.component.scss'
})
export class MultiTagComponent {
  @Input() moods : MoodLight[] = []
  @Output() trigger = new EventEmitter() 
  #flowService = inject(FlowService)
  menuService = inject(MenuDesktopService)
  multiTagService = inject(MultiTagService)
  paginationService = inject(PaginationService)

  environment = environment.apiBaseUrl

  flow = this.#flowService.flow
  moodsPerPage: number = 36 

  selectionToggle(moodId: number): void {
    this.multiTagService.selectionToggle(moodId)
  }
  checkIfSelected(moodId: number): boolean {
    return this.multiTagService.checkIfSelected(moodId)
  }
}