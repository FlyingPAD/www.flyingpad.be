import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { FranchiseFull, MediumCheckBox } from '../../../interfaces/franchise';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FranchiseUpdateForm } from '../../../interfaces/forms-update';
import { FranchiseService } from '../../../services/http/franchise.service';
import { DialogService } from '../../../services/user-interface/dialog.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-edit-franchise',
  templateUrl: './edit-franchise.component.html'
})
export class EditFranchiseComponent implements OnInit, OnDestroy {
  #franchiseService = inject(FranchiseService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() franchise: FranchiseFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup!: FormGroup


  ngOnInit(): void {
    if (this.franchise) {
      this.formGroup = this.#formBuilder.group({
        name: [this.franchise.name, [Validators.required, Validators.maxLength(50)]],
        description: [this.franchise.description, [Validators.required, Validators.maxLength(50)]],
        media: this.#formBuilder.array([])
      })

      this.#franchiseService.getMediaCheckBoxesByFranchise(this.franchise.businessId)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(media => this.populateCategories(media))
    }
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
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

  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateFranchise(): void {
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

      this.#franchiseService.updateFranchise(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateFranchise()
        break
    }
  }
}