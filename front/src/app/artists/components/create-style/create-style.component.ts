import { Component, OnDestroy, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ArtistsStateService } from '../../../core/services/artists-state.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-create-style',
  templateUrl: './create-style.component.html',
  styleUrls: ['./create-style.component.scss']
})
export class CreateStyleComponent implements OnDestroy
{ 
  #artistsService = inject(ArtistsStateService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #toastr = inject(ToastrService)

  form : FormGroup = this.#builder.group
  ({
    name : ["", [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  subscription = new Subscription()

  onSubmit() : void
  {
    if (this.form.valid) 
    {
      this.subscription = this.#artistsService.CreateStyle(this.form.value).subscribe({
        next : () => 
        {
          this.#toastr.success('Style was successfully created.')
          this.#router.navigateByUrl('artists')
        },
        error : () => 
        {
          this.#toastr.error('Error')
        }
      })
    }
  }

  ngOnDestroy() : void
  {
    this.subscription.unsubscribe()
  }
}