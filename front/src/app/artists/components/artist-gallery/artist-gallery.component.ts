import { Component, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { MoodStateService } from '../../../core/services/mood-state.service';
import { ArtistsStateService } from '../../../core/services/artists-state.service';

@Component({
  selector: 'app-artist-gallery',
  templateUrl: './artist-gallery.component.html',
  styleUrl: './artist-gallery.component.scss'
})
export class ArtistGalleryComponent
{
  #moodsService = inject(MoodStateService)
  #artistsService = inject(ArtistsStateService)
  menuService = inject(MenuMobileService)

  environment = environment.apiBaseUrl

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

}