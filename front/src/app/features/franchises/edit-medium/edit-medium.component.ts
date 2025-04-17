import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { MediumFull } from '../../../interfaces/franchise';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { MediumUpdateForm } from '../../../interfaces/forms-update';
import { FranchiseService } from '../../../services/http/franchise.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-medium',
  templateUrl: './edit-medium.component.html'
})
export class EditMediumComponent implements OnInit, OnDestroy {
  #franchiseService = inject(FranchiseService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() medium: MediumFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup!: FormGroup


  ngOnInit(): void {
    this.formGroup = this.#formBuilder.group({
      name: [this.medium?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(30)]],
      description: [this.medium?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(100)]]
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateMedium(): void {
    if (this.formGroup.valid && this.medium) {
      let form: MediumUpdateForm = {
        mediumId: this.medium.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description
      }

      this.#franchiseService.updateMedium(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateMedium()
        break
    }
  }
}