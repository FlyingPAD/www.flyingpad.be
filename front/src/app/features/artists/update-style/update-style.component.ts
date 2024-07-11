import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { ArtistsStateService } from '../../../services/artists.service';
import { StyleLight } from '../../../models/artist';

@Component({
  selector: 'app-update-style',
  templateUrl: './update-style.component.html',
  styleUrls: ['./update-style.component.scss']
})
export class UpdateStyleComponent
{
  #artistsService = inject(ArtistsStateService)
  #router = inject(Router)
  #toastr = inject(ToastrService)
  #builder = inject(FormBuilder)

  styleFlow = this.#artistsService.styleFlow  // Signal
  subscription = new Subscription()           // Subscription

  form : FormGroup = this.#builder.group
  ({
    name : [this.styleFlow().style?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnDestroy() : void 
  {
    this.subscription.unsubscribe()
  }
  
  onSubmit(): void {
    if (this.form.valid) 
    {
      let businessId = this.styleFlow().style?.businessId

      if (businessId !== undefined) 
      {
        let form : StyleLight = 
        {
          businessId : businessId,
          name : this.form.value.name
        }
  
        this.#artistsService.UpdateStyle( form ).subscribe({
          next: () => 
          {
            this.#router.navigateByUrl('/artists')
            this.#toastr.success('Style was successfully updated.')
          },
          error: () => 
          {
            this.#router.navigateByUrl('/artists')
            this.#toastr.error('Error: Style update failed!')
          }
        })
      } 
      else 
      {
        this.#toastr.error('Error: No valid business ID found for style.')
      }
    }
  }
}