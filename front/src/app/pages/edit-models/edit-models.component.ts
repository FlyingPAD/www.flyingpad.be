import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { Router } from '@angular/router';
import { ModelLight } from '../../models/model';
import { PaginationService } from '../../services/pagination.service';

@Component({
  selector: 'app-edit-models',
  templateUrl: './edit-models.component.html',
  styleUrl: './edit-models.component.scss'
})
export class EditModelsComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  paginationService = inject(PaginationService)

  flow = this.#flowService.flow

  searchModels: string = ''
  elementsPerPage: number = 18

  showList: boolean = true
  showNew: boolean = false
  showEdit: boolean = false

  triggerReset(): void {
    this.showList = false
    this.showNew = false
    this.showEdit = false
  }
  triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  triggerShowNew(): void {
    this.triggerReset()
    this.showNew = true
  }
  triggerShowEdit(): void {
    this.triggerReset()
    this.showEdit = true
  }

  filterModels(): ModelLight[] | undefined {
    return this.flow()?.models.filter(model => model.pseudonym.toLowerCase().includes(this.searchModels.toLowerCase()))
  }

  go(): void {
    this.#router.navigateByUrl('/moods')
  }

  setModel(model: ModelLight): void {
    this.#flowService.updateModelId(model.businessId)
  }
}