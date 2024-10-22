import { Component, inject, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ModelFull } from '../../../interfaces/model';
import { FlowService } from '../../../services/flow.service';
import { ToastrService } from 'ngx-toastr';
import { ModelUpdateForm } from '../../../interfaces/forms-update';

@Component({
  selector: 'app-model-details-flow',
  templateUrl: './model-details-flow.component.html',
  styleUrl: './model-details-flow.component.scss'
})
export class ModelDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() model! : ModelFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    pseudonym : [this.model?.pseudonym, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    firstName : [this.model?.firstName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    lastName : [this.model?.lastName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    gender : [this.model?.gender, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.model?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  update(): void {
    if (this.model && this.formGroup.valid) 
    {  
      let form : ModelUpdateForm = 
      {
       modelId : this.model?.businessId,
       pseudonym : this.formGroup.value.pseudonym,
       firstName : this.formGroup.value.firstName,
       lastName : this.formGroup.value.lastName,
       gender : this.formGroup.value.gender,
       description : this.formGroup.value.description,
       franchisesIds: []
      }
      this.#flowService.UpdateModel(form).subscribe({
        next: () => {
          this.#toastr.success('Model successfully updated.')
        },
        error: (error) => {
          this.#toastr.error('Error : ' + error);
        }
      })
    }
    this.formGroup.reset()
  }

  triggerDeleteModel(): void {
    this.triggerDelete = !this.triggerDelete
  }

  deleteModel(): void { 
    if(this.model)
      {
        this.#flowService.DeleteModel(this.model?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Mood successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}