import { Component, inject } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { ArtistsStateService } from '../../../core/services/artists-state.service';

@Component({
  selector: 'app-update-artist',
  templateUrl: './update-artist.component.html',
  styleUrls: ['./update-artist.component.scss']
})
export class UpdateArtistComponent
{
  #artistsService = inject(ArtistsStateService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #toastr = inject(ToastrService)

  artistFlow = this.#artistsService.artistFlow
  flow = this.#artistsService.getAllStyles

  subscription = new Subscription()

  formGroup: FormGroup = this.#builder.group({
    name: [this.artistFlow()?.artist.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    styles: this.#builder.array(this.flow().map(style => this.#builder.group({
      businessId: [style.businessId],
      name: [style.name],
      isChecked: [style.isChecked]
    })))
  })

  get getStyles()
  {
    return this.formGroup.get('styles') as FormArray
  }

  onSubmit() : void
  {
    if (this.formGroup.valid) 
    {
      this.subscription = this.#artistsService.UpdateArtist(this.formGroup.value).subscribe({
        next : () => 
        {
          this.#toastr.success('Artist was successfully updated.')
          this.#router.navigateByUrl('/artists')
        },
        error : () => 
        {
          this.#toastr.error('Error ...')
        }
      })
    }
  }

  ngOnDestroy() : void
  {
    this.subscription.unsubscribe()
  }
}