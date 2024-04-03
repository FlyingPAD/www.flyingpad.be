import { Component, inject } from '@angular/core';
import { ArtistsStateService } from '../../../core/services/artists-state.service';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-new-list',
  templateUrl: './new-list.component.html',
  styleUrl: './new-list.component.scss'
})
export class NewListComponent 
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