import { Component, inject } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ArtistsStateService } from '../../../core/services/artists.service';
import { MoodStateService } from '../../../core/services/mood.service';

@Component({
  selector: 'app-layout-artists',
  templateUrl: './layout-artists.component.html',
  styleUrls: ['./layout-artists.component.scss']
})
export class LayoutArtistsComponent
{
  #artistsService = inject(ArtistsStateService)
  #moodsService = inject(MoodStateService)

  nameSearchField : FormControl = this.#artistsService.nameSearchField

  artistsFlow = this.#artistsService.artistsFlow

  pagination(newStartId : number | null) : void 
  {
    this.#artistsService.updateStartId(newStartId)
  }

  resetStyles()
  {
    this.#artistsService.updateCurrentStyleId(null)
  }

  updateCurrentStyleId( styleId : number)
  {
    this.#artistsService.updateCurrentStyleId( styleId )
  }

  updateArtistId( artistId : number)
  {
    this.#artistsService.updateSelectedArtistId(artistId)
    this.#moodsService.updateSelectedArtistId(artistId)
  }

  getRandomMood()
  {
    this.#moodsService.updateSelectedGalleryType('')
    this.#moodsService.updateSelectedMoodId(null)
  }
}