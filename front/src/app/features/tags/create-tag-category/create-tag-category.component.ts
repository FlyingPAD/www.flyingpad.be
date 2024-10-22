import { Component, EventEmitter, inject, Output } from '@angular/core';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { TagCategoryCreateForm } from '../../../interfaces/forms-create';

@Component({
  selector: 'app-create-tag-category',
  templateUrl: './create-tag-category.component.html',
  styleUrl: './create-tag-category.component.scss'
})
export class CreateTagCategoryComponent {
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  createFormGroup : FormGroup = this.#formBuilder.group({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  subscription = new Subscription()

  onSubmit(): void {
    let form : TagCategoryCreateForm = {
      name : this.createFormGroup.value.name,
      description : this.createFormGroup.value.description,
    }

    if(this.createFormGroup.valid) {
      this.subscription = this.#flowService.CreateTagCategory(form).subscribe({
        next : () => {
          this.trigger.emit()
        }
      })
    }
  }
}