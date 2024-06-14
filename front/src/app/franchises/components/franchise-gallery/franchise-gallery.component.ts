import { Component, HostListener, inject } from '@angular/core';
import { Subscription } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { FranchiseStateService } from '../../../services/franchise.service';
import { ModelStateService } from '../../../services/model.service';
import { MoodStateService } from '../../../services/mood.service';
import { Location } from '@angular/common';
import { MenuDesktopService } from '../../../services/menu-desktop.service';

@Component({
  selector: 'app-franchise-gallery',
  templateUrl: './franchise-gallery.component.html',
  styleUrl: './franchise-gallery.component.scss'
})
export class FranchiseGalleryComponent 
{
  #moodsService = inject(MoodStateService)
  #franchisesService = inject(FranchiseStateService)  
  #modelsService = inject(ModelStateService)
  menuService = inject(MenuDesktopService)
  location = inject(Location)
  
  environment = environment.apiBaseUrl

  franchise = this.#franchisesService.franchise
  model$ = this.#modelsService.currentModel$

  modelSubscription = new Subscription()

  topButtonIsActive = false
  infoIsActive = false

  moodsPerPage : number = 36
  currentPage : number = 1

  ngOnDestroy() : void 
  {
    this.modelSubscription.unsubscribe()
  }

  getModel( modelId : number ) : void 
  {
    this.modelSubscription = this.#modelsService.GetOneDetails(modelId).subscribe({
      next : (data) => {
        this.#modelsService.updateCurrentModel(data)
      }
    })
  }

  updateModelId(modelId : number | null) : void 
  {
    this.#modelsService.updateSelectedModelId(modelId)
    this.#moodsService.updateSelectedModelId(modelId)
  }

  updateMoodId(moodId : number) : void 
  {
    this.#moodsService.updateSelectedGalleryType('franchise')
    this.#moodsService.updateSelectedMoodId(moodId)
  }

  getRandomMood() : void 
  {
    this.#moodsService.updateSelectedGalleryType('')
    this.#moodsService.updateSelectedMoodId(null)
  }

  menuTrigger()
  {
    this.menuService.menuRTrigger()
  }

  infoTrigger() : void 
  {
    this.infoIsActive = !this.infoIsActive
  }

  @HostListener('window:scroll', ['$event'])
  onWindowScroll() : void 
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
      case 'Enter':
        this.infoTrigger()
        break
    }
  }
}