import { Component, OnDestroy, inject } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ArtistsStateService } from '../../../services/artists.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-create-artist',
  templateUrl: './create-artist.component.html',
  styleUrls: ['./create-artist.component.scss']
})
export class CreateArtistComponent implements OnDestroy
{
  #artistsService = inject(ArtistsStateService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #toastr = inject(ToastrService)

  flow = this.#artistsService.getAllStyles

  subscription = new Subscription()

  formGroup: FormGroup = this.#builder.group({
    name: ["", [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
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
      this.subscription = this.#artistsService.CreateArtist(this.formGroup.value).subscribe({
        next : () => 
        {
          this.#toastr.success('Artist was successfully created.')
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