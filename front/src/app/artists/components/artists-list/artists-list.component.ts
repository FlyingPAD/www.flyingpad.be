import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ArtistsStateService } from '../../../core/services/artists-state.service';

@Component({
  selector: 'app-artists-list',
  templateUrl: './artists-list.component.html',
  styleUrls: ['./artists-list.component.scss']
})
export class ArtistsListComponent
{
  #artistsService = inject(ArtistsStateService)

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
}