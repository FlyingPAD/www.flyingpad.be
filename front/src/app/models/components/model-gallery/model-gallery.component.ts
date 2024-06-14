import { Component, HostListener, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { ModelStateService } from '../../../services/model.service';
import { FranchiseStateService } from '../../../services/franchise.service';
import { MoodStateService } from '../../../services/mood.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-model-gallery',
  templateUrl: './model-gallery.component.html',
  styleUrls: ['./model-gallery.component.scss']
})
export class ModelGalleryComponent 
{
  #modelsService = inject(ModelStateService)
  #moodsService = inject(MoodStateService)
  #franchisesService = inject(FranchiseStateService)
  location = inject(Location)

  environment = environment.apiBaseUrl
  model = this.#modelsService.model

  moodsPerPage : number = 36
  currentPage : number = 1

  topButtonIsActive = false
  infoIsActive = false

  updateFranchiseId(franchiseId : number | null)
  {
    this.#franchisesService.updateSelectedFranchiseId(franchiseId)
  }

  updateMoodId( moodId : number)
  {
    this.#moodsService.updateSelectedMoodId(moodId)
    this.#moodsService.updateSelectedGalleryType('model')
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
      case 'Enter':
        this.infoTrigger()
        break
    }
  }
}