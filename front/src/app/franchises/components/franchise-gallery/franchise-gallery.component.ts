import { Component, inject } from '@angular/core';
import { Subscription } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { ModelService } from '../../../core/services/client/client-model.service';
import { StateModelsService } from '../../../core/services/state/state-models.service';
import { FranchiseStateService } from '../../../core/services/franchise-state.service';
import { ModelStateService } from '../../../core/services/model-state.service';

@Component({
  selector: 'app-franchise-gallery',
  templateUrl: './franchise-gallery.component.html',
  styleUrl: './franchise-gallery.component.scss'
})
export class FranchiseGalleryComponent 
{
  #franchisesService = inject(FranchiseStateService)  
  #newModelsService = inject(ModelStateService)
  #modelsService = inject(ModelService)
  #modelsState = inject(StateModelsService)
  menuService = inject(MenuMobileService)
  
  environment = environment.apiBaseUrl
  franchise = this.#franchisesService.franchise
  model$ = this.#modelsState.currentModel$
  modelSubscription = new Subscription()

  mpp : number = 36     // Pagination
  p : number = 1        // Pagination

  ngOnDestroy()
  {
    this.modelSubscription.unsubscribe()
  }

  getModel( modelId : number )
  {
    this.modelSubscription = this.#modelsService.GetOneDetails(modelId).subscribe({
      next : (data) => {
        this.#modelsState.updateCurrentModel(data.model)
      }
    })
  }

  updateModelId(modelId : number | null)
  {
    this.#newModelsService.updateSelectedModelId(modelId)
  }
}