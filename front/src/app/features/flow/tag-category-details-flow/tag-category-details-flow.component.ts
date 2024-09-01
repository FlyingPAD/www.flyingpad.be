import { Component, inject, Input } from '@angular/core';
import { TagCategoryUpdateForm } from '../../../models/forms-update';
import { TagCategoryFull } from '../../../models/tag-category';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-tag-category-details-flow',
  templateUrl: './tag-category-details-flow.component.html',
  styleUrl: './tag-category-details-flow.component.scss'
})
export class TagCategoryDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() tagCategory! : TagCategoryFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.tagCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.tagCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
  })

  update(): void {
    if (this.tagCategory && this.formGroup.valid) 
    {  
      let form : TagCategoryUpdateForm = 
      {
       tagCategoryId : this.tagCategory?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description,
      }
      this.#flowService.UpdateTagCategory(form).subscribe({
        next: () => {
          this.#toastr.success('Tag Category successfully updated.')
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
    if(this.tagCategory)
      {
        this.#flowService.DeleteTagCategory(this.tagCategory?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Tag Category successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}