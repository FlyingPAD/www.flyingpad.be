import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { ModelFull } from '../../../interfaces/model';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { ModelUpdateForm } from '../../../interfaces/http/forms-update';
import { FranchiseCheckBox } from '../../../interfaces/franchise';
import { ModelService } from '../../../services/http/model.service';
import { FranchiseService } from '../../../services/http/franchise.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-model',
  templateUrl: './edit-model.component.html'
})
export class EditModelComponent implements OnInit, OnDestroy {
  #modelService = inject(ModelService)
  #franchiseService = inject(FranchiseService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() model: ModelFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup!: FormGroup


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

      this.#franchiseService.getFranchisesCheckBoxesByModel(this.model.businessId)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(franchises => this.populateCategories(franchises))
    }
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
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

  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateModel(): void {
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
      this.#modelService.updateModel(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateModel()
        break
    }
  }
}