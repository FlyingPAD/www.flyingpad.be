import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { FranchiseFull, MediumCheckBox } from '../../../models/franchise';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FlowService } from '../../../services/flow.service';
import { FranchiseUpdateForm } from '../../../models/forms-update';

@Component({
  selector: 'app-edit-franchise',
  templateUrl: './edit-franchise.component.html',
  styleUrl: './edit-franchise.component.scss'
})
export class EditFranchiseComponent {
  @Input() franchise : FranchiseFull | undefined = undefined
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  formGroup!: FormGroup
  isDeleteDialogOpen : boolean = false


  ngOnInit(): void {
    if (this.franchise) {
      this.formGroup = this.#formBuilder.group({
        name: [this.franchise.name, [Validators.required, Validators.maxLength(50)]],
        description: [this.franchise.description, [Validators.required, Validators.maxLength(50)]],
        media: this.#formBuilder.array([])
      })

      this.#flowService.getMediaCheckBoxesByFranchise(this.franchise.businessId)
        .subscribe(media => this.populateCategories(media))
    }
  }

  get mediaArray(): FormArray {
    return this.formGroup.get('media') as FormArray
  }

  populateCategories(media: MediumCheckBox[]): void {
    media.forEach(medium => {
      this.mediaArray.push(
        this.#formBuilder.group({
          businessId: medium.businessId,
          name: medium.name,
          isChecked: medium.isChecked || false
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
    this.trigger.emit()
  }

  onSubmit(): void {
    if (this.formGroup.valid && this.franchise) {
      let selectedMedia = this.formGroup.value.media
        .filter((media: { isChecked: boolean }) => media.isChecked)
        .map((media: { businessId: number }) => media.businessId)

      let form: FranchiseUpdateForm = {
        franchiseId: this.franchise.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description,
        mediaIds: selectedMedia
      }

      this.#flowService.UpdateFranchise(form).subscribe(response => { if(response.success) this.trigger.emit() })
    }
  }
}