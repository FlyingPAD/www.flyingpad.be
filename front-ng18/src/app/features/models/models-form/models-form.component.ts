import { Component, effect, inject, input, output } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { Model, ModelForm } from '../../../models/model';

@Component({
  selector: 'app-models-form',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './models-form.component.html',
  styleUrl: './models-form.component.scss'
})
export class ModelsFormComponent {
  model = input<Model>();
  #formBuilder = inject(FormBuilder);

  save = output<ModelForm>()

  formGroup = this.#formBuilder.nonNullable.group({
    pseudonym: ['', Validators.required],
    firstName: ['', Validators.required],
    lastName: ['', Validators.required],
    gender: ['']
  })

  constructor() {
    effect(() => {
      this.formGroup.setValue({ 
        pseudonym : this.model()?.pseudonym || '', 
        firstName : this.model()?.firstName || '', 
        lastName : this.model()?.lastName || '',
        gender : this.model()?.gender || '' })
    })
  }

  handleSave() {
    this.save.emit({ ...this.formGroup.getRawValue(), businessId : this.model()?.businessId })
  }
}