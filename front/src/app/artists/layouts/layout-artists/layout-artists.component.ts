import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { Style } from '../../../core/models/style';
import { StateArtistService } from '../../../core/services/state/state-artists.service';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { StyleService } from '../../../core/services/client/client-style.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-layout-artists',
  templateUrl: './layout-artists.component.html',
  styleUrls: ['./layout-artists.component.scss']
})
export class LayoutArtistsComponent implements OnInit, OnDestroy
{
  #stateArtistService = inject(StateArtistService)
  #styleService = inject(StyleService)
  menuMobileService = inject(MenuMobileService)

  // - Properties :

  artists$ = this.#stateArtistService.currentArtists$
  style$ = this.#stateArtistService.currentStyle$
  styles$ = this.#stateArtistService.totalStyles$

  subscription = new Subscription()

  ngOnInit() : void
  {
    this.subscription = this.#styleService.GetAll().subscribe({
      next : (data) => {
        this.#stateArtistService.updateTotalStyles(data.stylesList)
      }
    })
  }

  ngOnDestroy() : void
  {
    this.subscription.unsubscribe()
  }

  // - Methods :

  setStyle( style : Style ) : void
  {
    this.#stateArtistService.updateCurrentStyleId( style.businessId );
    this.#stateArtistService.updateCurrentStyle( style )
  }

  setAllStyles() : void
  {
    this.#stateArtistService.updateCurrentStyleId( null )
    this.#stateArtistService.updateCurrentStyle( new Style() )
  }
}