import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { MediumLight } from '../../../interfaces/franchise';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { FranchiseCreateForm } from '../../../interfaces/forms-create';
import { FranchiseService } from '../../../services/http/franchise.service';

@Component({
  selector: 'app-create-franchise',
  templateUrl: './create-franchise.component.html'
})
export class CreateFranchiseComponent implements OnInit, OnDestroy {
  @Input() media: MediumLight[] = []
  @Output() setViewMode = new EventEmitter<void>()

  #franchiseService = inject(FranchiseService)
  #builder = inject(FormBuilder)

  #destroy$ = new Subject<void>()

  formGroup!: FormGroup

  get mediaArray(): FormArray {
    return this.formGroup.get('media') as FormArray
  }

  ngOnInit(): void {
    this.formGroup = this.#builder.group({
      name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      media: this.#builder.array(
        this.media.map(medium => this.createMediumFormGroup(medium))
      )
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private createMediumFormGroup(medium: MediumLight): FormGroup {
    return this.#builder.group({
      businessId: [medium.businessId],
      name: [medium.name],
      isChecked: [false]
    })
  }

  public createFranchise(): void {
    if (this.formGroup.valid) {
      let media = this.mediaArray?.value

      if (media && Array.isArray(media)) {
        let form: FranchiseCreateForm = {
          name: this.formGroup.value.name,
          description: this.formGroup.value.description,
          mediaIds: media
            .filter((medium: { isChecked: boolean }) => medium.isChecked)
            .map((medium: { businessId: number }) => medium.businessId)
        }

        this.#franchiseService.createFranchise(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => { if (response.success) this.setViewMode.emit() })
      }
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.createFranchise()
        break
    }
  }
}