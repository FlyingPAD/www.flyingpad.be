import { Component, inject } from '@angular/core';
import { ModelStateService } from '../../../core/services/model.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.scss'
})
export class ListComponent 
{
  modelService = inject(ModelStateService)

  modelsFlow = this.modelService.models

  updateModelId( modelId : number )
  {

  }
}
