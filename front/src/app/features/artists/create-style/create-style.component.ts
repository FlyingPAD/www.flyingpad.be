import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { StyleCreateForm } from '../../../models/forms-create';

@Component({
  selector: 'app-create-style',
  templateUrl: './create-style.component.html',
  styleUrl: './create-style.component.scss'
})
export class CreateStyleComponent {
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  formGroup : FormGroup = this.#formBuilder.group({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  subscription = new Subscription()

  onSubmit(): void {
    let form : StyleCreateForm = {
      name : this.formGroup.value.name,
      description : this.formGroup.value.description,
    }

    if(this.formGroup.valid) {
      this.subscription = this.#flowService.CreateStyle(form).subscribe((response) => {
        if(response.success) this.trigger.emit() 
      })
    }
  }
}