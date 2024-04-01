import { Component, inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { ModelService } from '../../../core/services/client/client-model.service';
import { MoodService } from '../../../core/services/client/client-mood.service';
import { environment } from '../../../../environments/environment';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { FranchiseService } from '../../../core/services/client/client-franchise.service';
import { StateFranchisesService } from '../../../core/services/state/state-franchises.service';
import { StateModelsService } from '../../../core/services/state/state-models.service';
import { StateMoodsService } from '../../../core/services/state/state-moods.service';

@Component({
  selector: 'app-model-gallery',
  templateUrl: './model-gallery.component.html',
  styleUrls: ['./model-gallery.component.scss']
})
export class ModelGalleryComponent 
{
  #modelsState = inject(StateModelsService)
  #franchisesState = inject(StateFranchisesService)
  #moodsState = inject(StateMoodsService)

  #modelsService = inject(ModelService)
  #franchisesService = inject(FranchiseService)
  #moodsService = inject(MoodService)

  #route = inject(ActivatedRoute)
  menuService = inject(MenuMobileService)

  modelId : number = this.#route.snapshot.params['id']

  model$ = this.#modelsState.currentModel$
  franchises$ = this.#franchisesState.currentFranchises$
  moods$ = this.#moodsState.currentMoodsByModel$

  modelSubscription = new Subscription()
  franchisesSubscription = new Subscription()
  moodsSubscription = new Subscription()

  mpp : number = 36
  p : number = 1

  environment = environment.apiBaseUrl

  ngOnInit()
  {
    this.getModel()
    this.getFranchises()
    this.getMoods()
  }

  ngOnDestroy()
  {
    this.modelSubscription.unsubscribe()
    this.franchisesSubscription.unsubscribe()
    this.moodsSubscription.unsubscribe()
  }

  getModel()
  {
    if(this.modelId)
    {
      this.modelSubscription = this.#modelsService.GetOneDetails(this.modelId).subscribe({
        next : (data) => {
          this.#modelsState.updateCurrentModel(data.model)
        }
      })
    }
  }

  getFranchises()
  {
    if(this.modelId)
    {
      this.franchisesSubscription = this.#franchisesService.GetByModel( this.modelId ).subscribe({
        next : (data) => {
          this.#franchisesState.updateCurrentFranchises(data.franchisesByModel)
        }
      })
    }
  }

  getMoods()
  {
    if(this.modelId)
    {
      this.moodsSubscription = this.#moodsService.GetByModel(this.modelId).subscribe({
        next : (data) => {
          this.#moodsState.updateCurrentMoodsByModel(data.moods)
        }
      })
    }
  }

}