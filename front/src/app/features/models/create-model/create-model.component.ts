import { Component, EventEmitter, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ModelCreateForm } from '../../../models/forms-create';
import { FlowService } from '../../../services/flow.service';
import { FranchiseCheckBox } from '../../../models/franchise';

@Component({
  selector: 'app-create-model',
  templateUrl: './create-model.component.html',
  styleUrl: './create-model.component.scss'
})
export class CreateModelComponent implements OnInit, OnDestroy {
  @Input() franchises: FranchiseCheckBox[] = []
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  subscription = new Subscription()
  formGroup!: FormGroup

  get franchisesArray(): FormArray {
    return this.formGroup.get('franchises') as FormArray
  }

  ngOnInit(): void {
    this.formGroup = this.#formBuilder.group({
      pseudonym : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      firstName : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      lastName : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      gender : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      franchises: this.#formBuilder.array(
        this.franchises.map(franchise => this.createFranchiseFormGroup(franchise))
      )
    })
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }


  private createFranchiseFormGroup(franchise: FranchiseCheckBox): FormGroup {
    return this.#formBuilder.group({
      businessId: [franchise.businessId],
      name: [franchise.name],
      isChecked: [false]
    })
  }


  onSubmit(): void {
    if (this.formGroup.valid) {
      let franchises = this.franchisesArray?.value

      if (franchises && Array.isArray(franchises)) {
        let form: ModelCreateForm = {
          pseudonym: this.formGroup.value.pseudonym,
          firstName: this.formGroup.value.firstName,
          lastName: this.formGroup.value.lastName,
          gender: this.formGroup.value.gender,
          description: this.formGroup.value.description,
          franchisesIds: franchises
            .filter((franchise: { isChecked: boolean }) => franchise.isChecked)
            .map((franchise: { businessId: number }) => franchise.businessId)
        }

        this.subscription = this.#flowService.CreateModel(form).subscribe((response) => {if(response.success) this.trigger.emit()})
      }
    }
  }
}