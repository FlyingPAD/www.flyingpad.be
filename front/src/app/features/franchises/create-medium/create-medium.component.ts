import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { MediumCreateForm } from '../../../interfaces/forms-create';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-create-medium',
  templateUrl: './create-medium.component.html',
  styleUrl: './create-medium.component.scss'
})
export class CreateMediumComponent {
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  formGroup : FormGroup = this.#formBuilder.group({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  subscription = new Subscription()

  onSubmit(): void {
    let form : MediumCreateForm = {
      name : this.formGroup.value.name,
      description : this.formGroup.value.description,
    }

    if(this.formGroup.valid) {
      this.subscription = this.#flowService.CreateMedium(form).subscribe((response) => {
        if(response.success) this.trigger.emit() 
      })
    }
  }
}