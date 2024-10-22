import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { LinkCategoryCreateForm } from '../../../interfaces/forms-create';

@Component({
  selector: 'app-create-link-category',
  templateUrl: './create-link-category.component.html',
  styleUrl: './create-link-category.component.scss'
})
export class CreateLinkCategoryComponent {
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  formGroup : FormGroup = this.#formBuilder.group({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  subscription = new Subscription()

  onSubmit(): void {
    let form : LinkCategoryCreateForm = {
      name : this.formGroup.value.name,
      description : this.formGroup.value.description,
    }

    if(this.formGroup.valid) {
      this.subscription = this.#flowService.CreateLinkCategory(form).subscribe((response) => {
        if(response.success) this.trigger.emit() 
      })
    }
  }
}