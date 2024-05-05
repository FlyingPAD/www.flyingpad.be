import { Component, OnDestroy, inject } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { ArtistsStateService } from '../../../core/services/artists.service';

@Component({
  selector: 'app-delete-style',
  templateUrl: './delete-style.component.html',
  styleUrls: ['./delete-style.component.scss']
})
export class DeleteStyleComponent implements OnDestroy
{
  #artistsService = inject(ArtistsStateService)

  #router = inject(Router)
  #toastr = inject(ToastrService)

  styleFlow = this.#artistsService.styleFlow  // Signal
  subscription = new Subscription()           // Subscription

  ngOnDestroy() : void 
  {
    this.subscription.unsubscribe()
  }

  onDelete() : void 
  {
    const style = this.styleFlow().style;
    if (style?.businessId !== undefined) 
    {
      this.#artistsService.DeleteStyle(style.businessId).subscribe({
        next : () => 
        {
          this.#toastr.success('Style was successfully deleted.')
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
      this.#toastr.error('Error: No business ID found for style.')
    }
  }
}