import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { ModelFull } from '../../../interfaces/model';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ModelUpdateForm } from '../../../interfaces/forms-update';
import { FlowService } from '../../../services/http/flow.service';
import { FranchiseCheckBox } from '../../../interfaces/franchise';
import { ModelService } from '../../../services/http/model.service';

@Component({
  selector: 'app-edit-model',
  templateUrl: './edit-model.component.html',
  styleUrl: './edit-model.component.scss'
})
export class EditModelComponent implements OnInit, OnDestroy {
  @Input() model: ModelFull | undefined = undefined
  @Output() showListTrigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #modelService = inject(ModelService)
  #formBuilder = inject(FormBuilder)

  #subscription = new Subscription()

  public formGroup!: FormGroup
  public isDeleteDialogOpen: boolean = false

  ngOnInit(): void {
    if (this.model) {
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

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  get franchisesArray(): FormArray {
    return this.formGroup.get('franchises') as FormArray
  }

  private populateCategories(franchises: FranchiseCheckBox[]): void {
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

  public openDeleteDialog(): void {
    this.isDeleteDialogOpen = true
  }
  public closeDeleteDialog(): void {
    this.isDeleteDialogOpen = false
  }
  public closeDeleteDialogEmit(): void {
    this.isDeleteDialogOpen = false
    this.showListTrigger.emit()
  }

  public onSubmit(): void {
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
      this.#subscription = this.#modelService.updateModel(form).subscribe(response => { 
        if (response.success) this.showListTrigger.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}