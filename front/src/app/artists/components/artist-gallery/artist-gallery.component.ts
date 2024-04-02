import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { ArtistDetails } from '../../../core/models/artist';
import { MoodLight } from '../../../core/models/mood';
import { ArtistService } from '../../../core/services/client/client-artist.service';
import { MoodService } from '../../../core/services/client/client-mood.service';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { StateArtistService } from '../../../core/services/state/state-artists.service';
import { StateMoodsService } from '../../../core/services/state/state-moods.service';

@Component({
  selector: 'app-artist-gallery',
  templateUrl: './artist-gallery.component.html',
  styleUrl: './artist-gallery.component.scss'
})
export class ArtistGalleryComponent implements OnInit, OnDestroy
{
  #artistsState = inject(StateArtistService)
  #moodsState = inject(StateMoodsService)
  #artistService = inject(ArtistService)
  #moodsService = inject(MoodService)
  #route = inject(ActivatedRoute)
  menuService = inject(MenuMobileService)

  artistId : number = this.#route.snapshot.params['id']

  artist : ArtistDetails = new ArtistDetails()
  moods : MoodLight[] = []

  moodsSubscription = new Subscription()
  artistSubscription = new Subscription()
  
  mpp : number = 36
  p : number = 1

  environment = environment.apiBaseUrl

  ngOnInit() : void
  {
    this.getArtist()
    this.getMoods()
  }

  ngOnDestroy(): void 
  {
    this.artistSubscription.unsubscribe()
    this.moodsSubscription.unsubscribe()  
  }

  getArtist()
  {
    if(this.artistId)
    {
      this.artistSubscription = this.#artistService.GetOneDetails(this.artistId).subscribe({
        next : (data) => {
          this.artist = data.artist
          this.#artistsState.updateCurrentArtist(data.artist)
        }
      })
    }
  }

  getMoods()
  {
    if(this.artistId)
    {
      this.moodsSubscription = this.#moodsService.GetByArtist(this.artistId).subscribe({
        next : (data) => 
        {
          this.#moodsState.updateCurrentMoodsByArtist(data.moods)
          this.moods = data.moods
        }
      })
    }
  }

}