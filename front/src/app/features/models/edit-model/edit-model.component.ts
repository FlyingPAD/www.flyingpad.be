import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { ModelFull } from '../../../interfaces/model';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ModelUpdateForm } from '../../../interfaces/forms-update';
import { FlowService } from '../../../services/flow.service';
import { FranchiseCheckBox } from '../../../interfaces/franchise';

@Component({
  selector: 'app-edit-model',
  templateUrl: './edit-model.component.html',
  styleUrl: './edit-model.component.scss'
})
export class EditModelComponent implements OnInit {
  @Input() model: ModelFull | undefined = undefined
  @Output() showListTrigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  subscription = new Subscription()
  
  formGroup!: FormGroup
  isDeleteDialogOpen: boolean = false

  ngOnInit(): void {
    if(this.model) {
      this.formGroup = this.#formBuilder.group({
        pseudonym: [this.model?.pseudonym, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
        firstName: [this.model?.firstName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
        lastName: [this.model?.lastName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
        gender: [this.model?.gender, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
        description: [this.model?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
        franchises: this.#formBuilder.array([])
      })

      this.#flowService.getFranchisesCheckBoxesByModel(this.model.businessId)
        .subscribe(franchises => this.populateCategories(franchises))
    }
  }
  get franchisesArray(): FormArray {
    return this.formGroup.get('franchises') as FormArray
  }

  populateCategories(franchises: FranchiseCheckBox[]): void {
    franchises.forEach(franchise => {
      this.franchisesArray.push(
        this.#formBuilder.group({
          businessId: franchise.businessId,
          name: franchise.name,
          isChecked: franchise.isChecked || false
        })
      )
    })
  }
  openDeleteDialog(): void {
    this.isDeleteDialogOpen = true
  }
  closeDeleteDialog(): void {
    this.isDeleteDialogOpen = false
  }
  closeDeleteDialogEmit(): void {
    this.isDeleteDialogOpen = false
    this.showListTrigger.emit()
  }

  onSubmit(): void {
    if (this.formGroup.valid && this.model) {
      let selectedFranchises = this.formGroup.value.franchises
      .filter((franchise: { isChecked: boolean }) => franchise.isChecked)
      .map((franchise: { businessId: number }) => franchise.businessId)

      let form: ModelUpdateForm = {
        modelId: this.model.businessId,
        pseudonym: this.formGroup.value.pseudonym,
        firstName: this.formGroup.value.firstName,
        lastName: this.formGroup.value.lastName,
        gender: this.formGroup.value.gender,
        description: this.formGroup.value.description,
        franchisesIds: selectedFranchises
      }
      this.subscription = this.#flowService.UpdateModel(form).subscribe(response => { if (response.success) this.showListTrigger.emit() })
    }
  }
}