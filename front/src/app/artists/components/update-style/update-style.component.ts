import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { switchMap } from 'rxjs';
import { StylesGetOneResponse, StyleUpdateForm } from '../../../core/models/style';
import { StyleService } from '../../../core/services/client/client-style.service';

@Component({
  selector: 'app-update-style',
  templateUrl: './update-style.component.html',
  styleUrls: ['./update-style.component.scss']
})
export class UpdateStyleComponent implements OnInit
{
  // Properties :

  #styleService = inject(StyleService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #route = inject(ActivatedRoute)
  #toastr = inject(ToastrService)

  styleId : number = this.#route.snapshot.params['id']
  styleGetOneResponse : StylesGetOneResponse | null = null

  form : FormGroup = this.#builder.group
  ({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  // Methods :

  ngOnInit() 
  {
    window.scrollTo(0, 0)

    this.#route.params.subscribe(params => 
    {
      this.styleId = params['id'];
      this.loadStyle();
    })
  }

  loadStyle() 
  {
    this.#styleService.GetOne(this.styleId).subscribe({
      next: (response) => 
      {
        this.styleGetOneResponse = response;
        if (response.success && response.style) 
        {
          this.form.patchValue({ name: response.style.name });
        }
      },
    })
  }

  onSubmit()
  {
    if( this.form.valid )
    {      
      let style : StyleUpdateForm = 
      {
        businessId : this.styleId,
        name : this.form.value.name
      }

      this.#styleService.Update(style).pipe(
        switchMap( () => this.#styleService.GetAll() ),
        switchMap( () => this.#styleService.GetOne(this.styleId) )
        ).subscribe({
        next : () => 
        {
          this.#router.navigateByUrl('artists/list')
          this.#toastr.success('Style was successfully updated.')
        },
        error : () => 
        {
          this.#router.navigateByUrl('artists/list')
          this.#toastr.error('Error : Style update failed !')
        }
      })
    }
  }
}