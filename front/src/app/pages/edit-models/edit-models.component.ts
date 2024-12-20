import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { Router } from '@angular/router';
import { ModelLight } from '../../interfaces/model';
import { PaginationService } from '../../services/display/pagination.service';
import { ImageUrlService } from '../../services/display/image-url.service';

@Component({
  selector: 'app-edit-models',
  templateUrl: './edit-models.component.html',
  styleUrl: './edit-models.component.scss'
})
export class EditModelsComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  paginationService = inject(PaginationService)
  #imageURLService = inject(ImageUrlService)

  flow = this.#flowService.flow

  searchModels: string = ''
  elementsPerPage: number = 12

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

  public getImageUrl(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}