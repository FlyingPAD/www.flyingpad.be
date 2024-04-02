import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { Subscription, combineLatest } from 'rxjs';
import { debounceTime, switchMap, startWith } from 'rxjs/operators';
import { FormControl } from '@angular/forms';

import { ArtistService } from '../../../core/services/client/client-artist.service';
import { StateArtistService } from '../../../core/services/state/state-artists.service';

@Component({
  selector: 'app-artists-list',
  templateUrl: './artists-list.component.html',
  styleUrls: ['./artists-list.component.scss']
})
export class ArtistsListComponent implements OnInit, OnDestroy 
{
  #artistsState = inject(StateArtistService)
  #artistsService = inject(ArtistService)

  nameSearchField = new FormControl('')
  subscription = new Subscription()

  styleId$ = this.#artistsState.currentStyleId$
  style$ = this.#artistsState.currentStyle$
  artistPage$ = this.#artistsState.artistGetPageResponse$

  ngOnInit() : void 
  {
    const combined$ = combineLatest([
      this.styleId$,
      this.nameSearchField.valueChanges.pipe(startWith('')),
      this.#artistsState.currentStartId$
    ]).pipe(
      debounceTime(100),
      switchMap(([styleId, searchTerm, startId]) => 
      {
        this.#artistsState.updateNameSearchField(searchTerm ?? '');
        return this.#artistsService.GetPage(styleId, startId, searchTerm ?? '', 20)
      })
    );

    this.subscription.add(combined$.subscribe(response => 
    {
      this.#artistsState.updateGetPageResponse(response);
    }))
  }

  ngOnDestroy() : void 
  {
    this.subscription.unsubscribe()
  }

  pagination(newStartId : number | null) : void 
  {
    this.#artistsState.updateCurrentStartId(newStartId)
  }
}