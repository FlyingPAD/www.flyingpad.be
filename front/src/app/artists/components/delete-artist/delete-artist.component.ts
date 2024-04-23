import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ArtistsStateService } from '../../../core/services/artists-state.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-artist',
  templateUrl: './delete-artist.component.html',
  styleUrls: ['./delete-artist.component.scss']
})
export class DeleteArtistComponent
{
  #artistsService = inject(ArtistsStateService)

  #router = inject(Router)
  #toastr = inject(ToastrService)

  artistFlow = this.#artistsService.artistFlow  // Signal
  subscription = new Subscription()             // Subscription

  ngOnDestroy() : void 
  {
    this.subscription.unsubscribe()
  }

  onDelete() : void 
  {
    const artist = this.artistFlow()?.artist
    if (artist?.businessId !== undefined) 
    {
      this.#artistsService.DeleteArtist(artist.businessId).subscribe({
        next : () => 
        {
          this.#toastr.success('Artist was successfully deleted.')
          this.#router.navigateByUrl('/artists')
        },
        error : (error) => 
        {
          this.#toastr.error('Error : ' + error.message)
        }
      })
    } 
    else 
    {
      this.#toastr.error('Error: No business ID found for artist.')
    }
  }
}