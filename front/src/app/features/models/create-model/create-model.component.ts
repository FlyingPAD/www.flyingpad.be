import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ModelCreateForm } from '../../../models/forms-create';
import { FlowService } from '../../../services/flow.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-create-model',
  templateUrl: './create-model.component.html',
  styleUrl: './create-model.component.scss'
})
export class CreateModelComponent {
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)

  createFormGroup : FormGroup = this.#formBuilder.group
  ({
    pseudonym : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    firstName : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    lastName : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    gender : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  subscription = new Subscription()

  onSubmit()
  {
    let form : ModelCreateForm = 
    {
      pseudonym : this.createFormGroup.value.pseudonym,
      firstName : this.createFormGroup.value.firstName,
      lastName : this.createFormGroup.value.lastName,
      gender : this.createFormGroup.value.gender,
      description : this.createFormGroup.value.description,
    }

    if(this.createFormGroup.valid)
    {
      this.subscription = this.#flowService.CreateModel(form).subscribe({
        next : () => 
        {
          this.trigger.emit()
          this.#toastr.success('Model was created.')
        }
      })
    }
  }
}