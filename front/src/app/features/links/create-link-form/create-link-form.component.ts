import { Component, inject, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LinkFull } from '../../../models/link';
import { FlowService } from '../../../services/flow.service';
import { LinkCreateForm } from '../../../models/forms-create';

@Component({
  selector: 'app-create-link-form',
  templateUrl: './create-link-form.component.html',
  styleUrl: './create-link-form.component.scss'
})
export class CreateLinkFormComponent {
  #formBuilder = inject(FormBuilder)
  #flowService = inject(FlowService)

  @Input() link! : LinkFull
  createFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    url : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  onSubmit()
  {
    let form : LinkCreateForm =
    {
      name: this.createFormGroup.value.name,
      description: this.createFormGroup.value.description,
      url: this.createFormGroup.value.url

    }
    this.#flowService.CreateLink(form)
  }
}
