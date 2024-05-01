import { Component, HostListener, inject } from '@angular/core';
import { Subscription } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { ModelService } from '../../../core/services/client/client-model.service';
import { StateModelsService } from '../../../core/services/state/state-models.service';
import { FranchiseStateService } from '../../../core/services/franchise-state.service';
import { ModelStateService } from '../../../core/services/model-state.service';
import { MoodStateService } from '../../../core/services/mood-state.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-franchise-gallery',
  templateUrl: './franchise-gallery.component.html',
  styleUrl: './franchise-gallery.component.scss'
})
export class FranchiseGalleryComponent 
{
  #moodsService = inject(MoodStateService)
  #franchisesService = inject(FranchiseStateService)  
  #newModelsService = inject(ModelStateService)
  #modelsService = inject(ModelService)
  #modelsState = inject(StateModelsService)
  menuService = inject(MenuMobileService)
  location = inject(Location)
  
  environment = environment.apiBaseUrl
  franchise = this.#franchisesService.franchise
  model$ = this.#modelsState.currentModel$
  modelSubscription = new Subscription()
  topButtonIsActive = false
  infoIsActive = false

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
    this.#moodsService.updateSelectedModelId(modelId)
  }

  updateMoodId(moodId : number)
  {
    this.#moodsService.updateSelectedGalleryType('franchise')
    this.#moodsService.updateSelectedMoodId(moodId)
  }

  getRandomMood()
  {
    this.#moodsService.updateSelectedGalleryType('')
    this.#moodsService.updateSelectedMoodId(null)
  }

  infoTrigger()
  {
    this.infoIsActive = !this.infoIsActive
  }

  @HostListener('window:scroll', ['$event'])
  onWindowScroll() 
  {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }

  toTop() : void 
  {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }

  // KEYBOARD CONFIGURATION
  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    console.log(event.key)
    switch (event.key) 
    {
      case 'Backspace':
        this.location.back()
        break
      case 'Control':
        this.infoTrigger()
        break
    }
  }
}