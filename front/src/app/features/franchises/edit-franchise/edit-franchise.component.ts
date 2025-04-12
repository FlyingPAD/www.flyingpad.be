import { Component, EventEmitter, HostListener, inject, Input, OnInit, Output } from '@angular/core';
import { FranchiseFull, MediumCheckBox } from '../../../interfaces/franchise';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FranchiseUpdateForm } from '../../../interfaces/forms-update';
import { FranchiseService } from '../../../services/http/franchise.service';

@Component({
  selector: 'app-edit-franchise',
  templateUrl: './edit-franchise.component.html',
  styleUrl: './edit-franchise.component.scss'
})
export class EditFranchiseComponent implements OnInit {
  @Input() franchise: FranchiseFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #franchiseService = inject(FranchiseService)
  #formBuilder = inject(FormBuilder)

  public formGroup!: FormGroup
  public isDeleteDialogOpen: boolean = false


  ngOnInit(): void {
    if (this.franchise) {
      this.formGroup = this.#formBuilder.group({
        name: [this.franchise.name, [Validators.required, Validators.maxLength(50)]],
        description: [this.franchise.description, [Validators.required, Validators.maxLength(50)]],
        media: this.#formBuilder.array([])
      })

      this.#franchiseService.getMediaCheckBoxesByFranchise(this.franchise.businessId)
        .subscribe(media => this.populateCategories(media))
    }
  }

  get mediaArray(): FormArray {
    return this.formGroup.get('media') as FormArray
  }

  private populateCategories(media: MediumCheckBox[]): void {
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

  public openDeleteDialog(): void {
    this.isDeleteDialogOpen = true
  }
  public closeDeleteDialog(): void {
    this.isDeleteDialogOpen = false
  }
  public closeDeleteDialogEmit(): void {
    this.isDeleteDialogOpen = false
    this.setViewMode.emit()
  }

  public onSubmit(): void {
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

      this.#franchiseService.updateFranchise(form).subscribe(response => { if (response.success) this.setViewMode.emit() })
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