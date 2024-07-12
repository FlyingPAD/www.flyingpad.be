import { Component, inject, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ModelFull } from '../../../models/model';

@Component({
  selector: 'app-model-details-flow',
  templateUrl: './model-details-flow.component.html',
  styleUrl: './model-details-flow.component.scss'
})
export class ModelDetailsFlowComponent {
  #formBuilder = inject(FormBuilder)
  @Input() model! : ModelFull | undefined

  formGroup : FormGroup = this.#formBuilder.group
  ({
    pseudonym : [this.model?.pseudonym, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.model?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
}
