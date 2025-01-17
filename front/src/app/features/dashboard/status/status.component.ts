import { Component, inject } from '@angular/core';
import { FlowService } from '../../../services/flow.service';
import { environment } from '../../../../environments/environment';
import { MoodsService } from '../../../services/moods.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-status',
  templateUrl: './status.component.html',
  styleUrl: './status.component.scss'
})
export class StatusComponent {
  #flowService = inject(FlowService)
  #moodsService = inject(MoodsService)
  #router = inject(Router)

  public flow = this.#flowService.flow
  public environment: string = environment.apiBaseUrl

  public goToCurrentMood(): void {
    this.#moodsService.updateMoodMenuState('details')
    this.#router.navigateByUrl('/moods')
  }

  public goToCurrentTag(tagId: number): void {
    this.#flowService.updateTagId(tagId)
    this.#moodsService.updateMoodMenuState('gallery')
    this.#router.navigateByUrl('/moods')
  }
}