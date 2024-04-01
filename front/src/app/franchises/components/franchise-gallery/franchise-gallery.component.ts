import { Component, inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, Subscription } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { GetOneFranchiseDetailsResponse } from '../../../core/models/franchise';
import { FranchiseService } from '../../../core/services/client/client-franchise.service';
import { MoodService } from '../../../core/services/client/client-mood.service';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { ModelService } from '../../../core/services/client/client-model.service';
import { ModelDetails, ModelLight } from '../../../core/models/model';
import { StateModelsService } from '../../../core/services/state/state-models.service';
import { StateMoodsService } from '../../../core/services/state/state-moods.service';

@Component({
  selector: 'app-franchise-gallery',
  templateUrl: './franchise-gallery.component.html',
  styleUrl: './franchise-gallery.component.scss'
})
export class FranchiseGalleryComponent 
{
  #franchisesService = inject(FranchiseService)

  #modelsService = inject(ModelService)
  #modelsState = inject(StateModelsService)
  #moodsService = inject(MoodService)
  #moodsState = inject(StateMoodsService)

  #route = inject(ActivatedRoute)
  menuService = inject(MenuMobileService)

  franchiseId : number = this.#route.snapshot.params['id']

  franchise$! : Observable<GetOneFranchiseDetailsResponse>

  moods$ = this.#moodsState.currentMoodsByFranchise$

  totalMoodsByFranchise : number = 0

  model$ = this.#modelsState.currentModel$
  models$ = this.#modelsState.currentModels$
  modelsF$ = this.#modelsState.currentModelsF$
  modelsM$ = this.#modelsState.currentModelsM$

  moodsSubscription = new Subscription()
  modelSubscription = new Subscription()
  modelsSubscription = new Subscription()

  mpp : number = 36
  p : number = 1

  environment = environment.apiBaseUrl

  ngOnInit()
  {
    this.getFranchise()
    this.getModels()
    this.getMoods()
  }

  ngOnDestroy()
  {
    this.moodsSubscription.unsubscribe()
    this.modelSubscription.unsubscribe()
    this.modelsSubscription.unsubscribe()
  }

  getFranchise()
  {
    if(this.franchiseId)
    {
      this.franchise$ = this.#franchisesService.GetOneDetails(this.franchiseId)
    }
  }

  getModels()
  {
    if(this.franchiseId)
    {
      this.modelsSubscription = this.#modelsService.GetByFranchise(this.franchiseId).subscribe({
        next : (data) => 
        {
          this.#modelsState.updateCurrentModels(data.modelsByFranchise)

          let modelsF : ModelLight[] = []
          let modelsM : ModelLight[] = []

          data.modelsByFranchise.forEach(element => 
          {
            if(element.gender === 'F')
            {
              modelsF.push(element)
            }
            if(element.gender === 'M')
            {
              modelsM.push(element)
            }
          })
          this.#modelsState.updateCurrentModelsF(modelsF)
          this.#modelsState.updateCurrentModelsM(modelsM)
        }
      })
    }
  }

  getMoods()
  {
    this.#modelsState.updateCurrentModel(new ModelDetails())

    if(this.franchiseId)
    {
      this.moodsSubscription = this.#moodsService.GetByFranchise(this.franchiseId).subscribe({
        next : (data) => {
          this.#moodsState.updateCurrentMoodsByFranchise(data.moods)
          this.totalMoodsByFranchise = data.moods.length
        }
      })
    }
  }

  getModel( modelId : number )
  {
    this.modelSubscription = this.#modelsService.GetOneDetails(modelId).subscribe({
      next : (data) => {
        this.#modelsState.updateCurrentModel(data.model)
      }
    })
    this.moodsSubscription = this.#moodsService.GetByModel(modelId).subscribe({
      next : (data) => {
        this.#moodsState.updateCurrentMoodsByFranchise(data.moods)
      }
    })
  }

}