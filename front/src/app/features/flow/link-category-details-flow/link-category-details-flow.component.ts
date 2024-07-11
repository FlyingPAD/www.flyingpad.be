import { Component, inject, Input } from '@angular/core';
import { LinkCategoryFull } from '../../../models/link';
import { LinkCategoryUpdateForm } from '../../../models/forms-update';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-link-category-details-flow',
  templateUrl: './link-category-details-flow.component.html',
  styleUrl: './link-category-details-flow.component.scss'
})
export class LinkCategoryDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() linkCategory! : LinkCategoryFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.linkCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.linkCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
  })

  update(): void {
    if (this.linkCategory && this.formGroup.valid) 
    {  
      let form : LinkCategoryUpdateForm = 
      {
       linkCategoryId : this.linkCategory?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description,
      }
      this.#flowService.UpdateLinkCategory(form).subscribe({
        next: () => {
          this.#toastr.success('Link Category successfully updated.')
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
    if(this.linkCategory)
      {
        this.#flowService.DeleteLink(this.linkCategory?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Link Category successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}