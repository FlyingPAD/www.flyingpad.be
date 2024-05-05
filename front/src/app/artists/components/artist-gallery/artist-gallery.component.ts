import { Component, HostListener, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { MoodStateService } from '../../../core/services/mood.service';
import { ArtistsStateService } from '../../../core/services/artists.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-artist-gallery',
  templateUrl: './artist-gallery.component.html',
  styleUrl: './artist-gallery.component.scss'
})
export class ArtistGalleryComponent
{
  #moodsService = inject(MoodStateService)
  #artistsService = inject(ArtistsStateService)
  location = inject(Location)

  environment = environment.apiBaseUrl
  topButtonIsActive = false
  infoIsActive = false

  artistFlow = this.#artistsService.artistFlow
  
  mpp : number = 36
  p : number = 1

  getRandomMood()
  {
    this.#moodsService.updateSelectedGalleryType('')
    this.#moodsService.updateSelectedMoodId(null)
  }

  updateMoodId( moodId : number)
  {
    this.#moodsService.updateSelectedGalleryType('artist')
    this.#moodsService.updateSelectedMoodId(moodId)
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