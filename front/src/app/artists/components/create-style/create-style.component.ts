import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { switchMap } from 'rxjs';
import { StyleService } from '../../../core/services/client/client-style.service';

@Component({
  selector: 'app-create-style',
  templateUrl: './create-style.component.html',
  styleUrls: ['./create-style.component.scss']
})
export class CreateStyleComponent
{
  // Properties :
  
  #styleService = inject(StyleService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #toastr = inject(ToastrService)

  form : FormGroup = this.#builder.group
  ({
    name : ["", [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  // Methods :

  onSubmit() : void
  {
    if (this.form.valid) 
    {
      this.#styleService.Create(this.form.value).pipe(
        switchMap(() => this.#styleService.GetAll()),
        switchMap(() => this.#styleService.Count())
      ).subscribe({
        next: () => {
          this.#toastr.success('Style was successfully created.')
          this.#router.navigateByUrl('artists')
        },
        error: () => {
          this.#toastr.error('Error')
        }
      })
    }
  }
}