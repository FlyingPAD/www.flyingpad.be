import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { ModelCreateForm } from '../../../interfaces/forms-create';
import { FranchiseLight } from '../../../interfaces/franchise';
import { ModelService } from '../../../services/http/model.service';

@Component({
  selector: 'app-create-model',
  templateUrl: './create-model.component.html'
})
export class CreateModelComponent implements OnInit, OnDestroy {
  @Input() franchises: FranchiseLight[] = []
  @Output() setViewMode = new EventEmitter<void>()

  #modelService = inject(ModelService)
  #formBuilder = inject(FormBuilder)

  #destroy$ = new Subject<void>()
  public formGroup!: FormGroup

  get franchisesArray(): FormArray {
    return this.formGroup.get('franchises') as FormArray
  }

  ngOnInit(): void {
    this.formGroup = this.#formBuilder.group({
      pseudonym: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      firstName: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      lastName: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      gender: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      franchises: this.#formBuilder.array(
        this.franchises.map(franchise => this.createFranchiseFormGroup(franchise))
      )
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private createFranchiseFormGroup(franchise: FranchiseLight): FormGroup {
    return this.#formBuilder.group({
      businessId: [franchise.businessId],
      name: [franchise.name],
      isChecked: [false]
    })
  }

  public createModel(): void {
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

        this.#modelService.createModel(form)
          .pipe(takeUntil(this.#destroy$))
          .subscribe(response => { if (response.success) this.setViewMode.emit() })
      }
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.createModel()
        break
    }
  }
}