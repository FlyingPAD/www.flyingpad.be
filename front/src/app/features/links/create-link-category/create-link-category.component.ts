import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { LinkCategoryCreateForm } from '../../../models/forms-create';

@Component({
  selector: 'app-create-link-category',
  templateUrl: './create-link-category.component.html',
  styleUrl: './create-link-category.component.scss'
})
export class CreateLinkCategoryComponent {
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  createFormGroup : FormGroup = this.#formBuilder.group({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  subscription = new Subscription()

  onSubmit(): void {
    let form : LinkCategoryCreateForm = {
      name : this.createFormGroup.value.name,
      description : this.createFormGroup.value.description,
    }

    if(this.createFormGroup.valid) {
      this.subscription = this.#flowService.CreateLinkCategory(form).subscribe({
        next : (response) => {
          if(response.success) this.trigger.emit()
        }
      })
    }
  }
}