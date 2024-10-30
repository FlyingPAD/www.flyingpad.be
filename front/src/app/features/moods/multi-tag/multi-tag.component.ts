import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { FlowService } from '../../../services/flow.service';
import { MultiTagService } from '../../../services/features/multi-tag.service';
import { PaginationService } from '../../../services/display/pagination.service';
import { MoodLight } from '../../../interfaces/mood';

@Component({
  selector: 'app-multi-tag',
  templateUrl: './multi-tag.component.html',
  styleUrl: './multi-tag.component.scss'
})
export class MultiTagComponent {
  @Input() moods : MoodLight[] = []
  #flowService = inject(FlowService)
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