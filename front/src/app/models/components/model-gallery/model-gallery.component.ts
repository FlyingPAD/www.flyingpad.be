import { Component, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { ModelStateService } from '../../../core/services/model-state.service';
import { FranchiseStateService } from '../../../core/services/franchise-state.service';

@Component({
  selector: 'app-model-gallery',
  templateUrl: './model-gallery.component.html',
  styleUrls: ['./model-gallery.component.scss']
})
export class ModelGalleryComponent 
{
  #ModelsService = inject(ModelStateService)
  #franchisesService = inject(FranchiseStateService)
  menuService = inject(MenuMobileService)

  mpp : number = 36
  p : number = 1

  environment = environment.apiBaseUrl
  model = this.#ModelsService.model

  updateFranchiseId(franchiseId : number | null)
  {
    this.#franchisesService.updateSelectedFranchiseId(franchiseId)
  }
}