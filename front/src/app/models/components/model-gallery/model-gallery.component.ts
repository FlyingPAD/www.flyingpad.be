import { Component, HostListener, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { ModelStateService } from '../../../core/services/model.service';
import { FranchiseStateService } from '../../../core/services/franchise.service';
import { MoodStateService } from '../../../core/services/mood.service';
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

  mpp : number = 36                       // Pagination
  p : number = 1                          // Pagination
  environment = environment.apiBaseUrl    // API URL
  topButtonIsActive = false               // To Top Button Trigger
  infoIsActive = false                    // Info Box Trigger
  model = this.#modelsService.model       // Signal Flow

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