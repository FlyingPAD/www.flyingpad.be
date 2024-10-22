import { Component, inject, Input } from '@angular/core';
import { TagUpdateForm } from '../../../interfaces/forms-update';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { TagFull } from '../../../interfaces/tag';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-tag-details-flow',
  templateUrl: './tag-details-flow.component.html',
  styleUrl: './tag-details-flow.component.scss'
})
export class TagDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() tag! : TagFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.tag?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.tag?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
  })

  update(): void {
    if (this.tag && this.formGroup.valid) 
    {  
      let form : TagUpdateForm = 
      {
       tagId : this.tag?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description,
       tagCategoryId : 0
      }
      this.#flowService.UpdateTag(form).subscribe({
        next: () => {
          this.#toastr.success('Tag successfully updated.')
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
    if(this.tag)
      {
        this.#flowService.DeleteTag(this.tag?.businessId, this.tag.tagCategoryId).subscribe({
          next: () => {
            this.#toastr.success('Tag successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}