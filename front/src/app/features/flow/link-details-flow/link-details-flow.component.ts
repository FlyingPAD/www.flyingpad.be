import { Component, inject, Input } from '@angular/core';
import { LinkFull } from '../../../interfaces/link';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { FlowService } from '../../../services/flow.service';
import { LinkUpdateForm } from '../../../interfaces/forms-update';

@Component({
  selector: 'app-link-details-flow',
  templateUrl: './link-details-flow.component.html',
  styleUrl: './link-details-flow.component.scss'
})
export class LinkDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() link! : LinkFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.link?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.link?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    url : [this.link?.url, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
  })

  update(): void {
    if (this.link && this.formGroup.valid) 
    {  
      let form : LinkUpdateForm = 
      {
       linkId : this.link?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description,
       url : this.formGroup.value.url,
       linkCategoryIds: []
      }
      this.#flowService.UpdateLink(form).subscribe({
        next: () => {
          this.#toastr.success('Link successfully updated.')
        },
        error: (error) => {
          this.#toastr.error('Error : ' + error);
        }
      })
    }
    this.formGroup.reset()
  }

  triggerDeleteLink(): void {
    this.triggerDelete = !this.triggerDelete
  }

  deleteLink(): void { 
    if(this.link)
      {
        this.#flowService.DeleteLink(this.link?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Link successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}