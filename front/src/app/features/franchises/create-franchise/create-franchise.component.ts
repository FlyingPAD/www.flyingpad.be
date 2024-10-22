import { Component, EventEmitter, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { MediumCheckBox } from '../../../interfaces/franchise';
import { FlowService } from '../../../services/flow.service';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { FranchiseCreateForm } from '../../../interfaces/forms-create';

@Component({
  selector: 'app-create-franchise',
  templateUrl: './create-franchise.component.html',
  styleUrl: './create-franchise.component.scss'
})
export class CreateFranchiseComponent implements OnInit, OnDestroy {
  @Input() media: MediumCheckBox[] = []
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #builder = inject(FormBuilder)

  subscription = new Subscription()
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

  private createMediumFormGroup(medium: MediumCheckBox): FormGroup {
    return this.#builder.group({
      businessId: [medium.businessId],
      name: [medium.name],
      isChecked: [false]
    })
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  onSubmit(): void {
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

        this.subscription = this.#flowService.CreateFranchise(form).subscribe((response) => {if(response.success) this.trigger.emit()})
      }
    }
  }
}