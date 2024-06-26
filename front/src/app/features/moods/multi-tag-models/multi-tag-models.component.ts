import { Component, OnDestroy, inject } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { Router } from '@angular/router';
import { RelationsMoodModelForm } from '../../../models/relations';
import { MultiTagService } from '../../../services/multi-tag.service';
import { RelationService } from '../../../services/relation.service';

@Component({
  selector: 'app-multi-tag-models',
  templateUrl: './multi-tag-models.component.html',
  styleUrl: './multi-tag-models.component.scss'
})
export class MultiTagModelsComponent implements OnDestroy
{
  multiTagService = inject(MultiTagService)
  relationService = inject(RelationService)
  router = inject(Router)

  models$ = this.multiTagService.getModels()
  models = toSignal(this.models$)

  searchModel : string = ''

  ngOnDestroy(): void {
    this.multiTagService.reset()
  }
  
  onSubmit()
  {
    let form : RelationsMoodModelForm = new RelationsMoodModelForm()
    let idListModels : number[] = []
    this.models()?.forEach(model => {
      if (model.isChecked)
      {
        idListModels.push(model.businessId)
      }
    })
    form.modelIds = idListModels

    this.multiTagService.selectedMoods.forEach(mood => {
      form.moodId = mood      
      this.relationService.InsertRMM(form).subscribe()
    })
    this.router.navigateByUrl('/moods')
  }

    // Filter models based on search input
    filterModels() 
    {
      return this.models()?.filter(m => m.pseudonym.toLowerCase().includes(this.searchModel.toLowerCase()))
    }
}