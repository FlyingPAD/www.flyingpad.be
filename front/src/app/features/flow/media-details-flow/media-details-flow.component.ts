import { Component, inject, Input } from '@angular/core';
import { MediaFull } from '../../../models/franchise';
import { MediaUpdateForm } from '../../../models/forms-update';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-media-details-flow',
  templateUrl: './media-details-flow.component.html',
  styleUrl: './media-details-flow.component.scss'
})
export class MediaDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() media! : MediaFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.media?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.media?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
  })

  update(): void {
    if (this.media && this.formGroup.valid) 
    {  
      let form : MediaUpdateForm = 
      {
       mediaId : this.media?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description,
      }
      this.#flowService.UpdateMedia(form).subscribe({
        next: () => {
          this.#toastr.success('Media successfully updated.')
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
    if(this.media)
      {
        this.#flowService.DeleteMedia(this.media?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Media successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}