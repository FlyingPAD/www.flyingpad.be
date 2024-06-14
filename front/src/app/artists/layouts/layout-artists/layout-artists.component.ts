import { Component, inject } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ArtistsStateService } from '../../../services/artists.service';
import { MoodStateService } from '../../../services/mood.service';
import { MenuDesktopService } from '../../../services/menu-desktop.service';

@Component({
  selector: 'app-layout-artists',
  templateUrl: './layout-artists.component.html',
  styleUrls: ['./layout-artists.component.scss']
})
export class LayoutArtistsComponent
{
  #artistsService = inject(ArtistsStateService)
  #moodsService = inject(MoodStateService)
  menuService = inject(MenuDesktopService)

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

  menuTrigger() : void
  {
    this.menuService.menuRActive = !this.menuService.menuRActive
  }
}