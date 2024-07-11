import { Component, inject, Input } from '@angular/core';
import { StyleUpdateForm } from '../../../models/forms-update';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { FlowService } from '../../../services/flow.service';
import { StyleFull } from '../../../models/artist';

@Component({
  selector: 'app-style-details-flow',
  templateUrl: './style-details-flow.component.html',
  styleUrl: './style-details-flow.component.scss'
})
export class StyleDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() style! : StyleFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.style?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
  })

  update(): void {
    if (this.style && this.formGroup.valid) 
    {  
      let form : StyleUpdateForm = 
      {
       styleId : this.style?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description,
      }
      this.#flowService.UpdateStyle(form).subscribe({
        next: () => {
          this.#toastr.success('Style successfully updated.')
        },
        error: (error) => {
          this.#toastr.error('Error : ' + error);
        }
      })
    }
    this.formGroup.reset()
  }

  triggerDeleteDialog(): void {
    this.triggerDelete = !this.triggerDelete
  }

  delete(): void { 
    if(this.style)
      {
        this.#flowService.DeleteStyle(this.style?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Style successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}