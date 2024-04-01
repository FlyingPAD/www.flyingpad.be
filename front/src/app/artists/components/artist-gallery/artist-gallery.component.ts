import { Component, inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { GetOneArtistDetailsResponse } from '../../../core/models/artist';
import { GetMoodsByArtistResponse } from '../../../core/models/mood';
import { ArtistService } from '../../../core/services/client/client-artist.service';
import { MoodService } from '../../../core/services/client/client-mood.service';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';

@Component({
  selector: 'app-artist-gallery',
  templateUrl: './artist-gallery.component.html',
  styleUrl: './artist-gallery.component.scss'
})
export class ArtistGalleryComponent
{
  #artistService = inject(ArtistService)
  #moodsService = inject(MoodService)
  #route = inject(ActivatedRoute)
  menuService = inject(MenuMobileService)

  artistId : number = this.#route.snapshot.params['id']

  artist$! : Observable<GetOneArtistDetailsResponse>
  moods$! : Observable<GetMoodsByArtistResponse>

  mpp : number = 36
  p : number = 1

  environment = environment.apiBaseUrl

  ngOnInit()
  {
    this.getArtist()
    this.getMoods()
  }

  getArtist()
  {
    if(this.artistId)
    {
      this.artist$ = this.#artistService.GetOneDetails(this.artistId)
    }
  }

  getMoods()
  {
    if(this.artistId)
    {
      this.moods$ = this.#moodsService.GetByArtist(this.artistId)
    }
  }

}