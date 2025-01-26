import { Component, inject, Input } from '@angular/core';
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
  #paginationService = inject(PaginationService)
  multiTagService = inject(MultiTagService)

  public flow = this.#flowService.flow
  public currentPage = this.#paginationService.moodsByTagCurrentPage
  public moodsPerPage: number = 36 
  public environment = environment.apiBaseUrl

  public updateCurrentPage(page: number): void {
    this.#paginationService.updateMoodsByTagCurrentPage(page)
  }

  public selectionToggle(moodId: number): void {
    this.multiTagService.selectionToggle(moodId)
  }
  
  public checkIfSelected(moodId: number): boolean {
    return this.multiTagService.checkIfSelected(moodId)
  }
}