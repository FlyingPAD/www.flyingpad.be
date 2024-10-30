import { Component, OnDestroy, inject } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { Router } from '@angular/router';
import { RelationsMoodModelForm } from '../../../interfaces/relations';
import { MultiTagService } from '../../../services/features/multi-tag.service';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-multi-tag-models',
  templateUrl: './multi-tag-models.component.html',
  styleUrl: './multi-tag-models.component.scss'
})
export class MultiTagModelsComponent implements OnDestroy
{
  #flowService = inject(FlowService)
  multiTagService = inject(MultiTagService)
  router = inject(Router)

  models$ = this.multiTagService.getModels()
  models = toSignal(this.models$)

  searchModel : string = ''

  ngOnDestroy(): void {
    this.multiTagService.reset()
  }
  
  onSubmit() {
    let form : RelationsMoodModelForm = {
      moodId: 0,
      modelIds : []
    }

    let idListModels: number[] = []

    this.models()?.forEach(model => {
      if (model.isChecked) {
        idListModels.push(model.businessId)
      }
    })
    form.modelIds = idListModels

    this.multiTagService.selectedMoods.forEach(mood => {
      form.moodId = mood      
      this.#flowService.InsertRMM(form).subscribe()
    })
    this.router.navigateByUrl('/moods')
  }

  filterModels() {
    return this.models()?.filter(m => m.pseudonym.toLowerCase().includes(this.searchModel.toLowerCase()))
  }
}