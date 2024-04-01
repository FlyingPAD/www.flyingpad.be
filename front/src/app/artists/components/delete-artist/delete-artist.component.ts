import { Component, inject } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { switchMap } from 'rxjs';
import { ArtistService } from '../../../core/services/client/client-artist.service';
import { StyleService } from '../../../core/services/client/client-style.service';
import { StateArtistService } from '../../../core/services/state/state-artists.service';

@Component({
  selector: 'app-delete-artist',
  templateUrl: './delete-artist.component.html',
  styleUrls: ['./delete-artist.component.scss']
})
export class DeleteArtistComponent
{
  #stateArtistService = inject(StateArtistService)
  #artistService = inject(ArtistService)
  #styleService = inject(StyleService)
  #router = inject(Router)
  #route = inject(ActivatedRoute)
  #toastr = inject(ToastrService)

  styleId : number | null = null
  nameSearchField : string = ''

  artistId : number = this.#route.snapshot.params['id']
  artist = this.#stateArtistService.currentArtist$

  // - Methods :

  ngOnInit()
  {
    if(this.artistId) 
    {
      this.#artistService.GetOne(this.artistId).subscribe({
        error: () => this.#toastr.error('Artist was not found.')
      })
    } 
    else 
    {
      this.#toastr.error('Invalid style ID.')
      this.#router.navigateByUrl('artists')
    }
    this.#stateArtistService.nameSearchField$.subscribe((nameSearchField) => { this.nameSearchField = nameSearchField })
    this.#styleService.styleId$.subscribe((input) => { this.styleId = input })
  }

  onDelete() 
  {
    this.#artistService.Delete(this.artistId).pipe(
      switchMap(() => this.#artistService.Count()),
      switchMap(() => this.#artistService.GetPage(this.styleId, null, this.nameSearchField, 20))
    ).subscribe({
      next: () => 
      {
        this.#toastr.success('Artist was successfully deleted.');
        this.#router.navigateByUrl('artists');
      },
      error: () => 
      {
        this.#toastr.error('Error')
      }
    })
  }
}