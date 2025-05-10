import { Component, EventEmitter, HostListener, inject, OnDestroy, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { MediumCreateForm } from '../../../interfaces/http/forms-create';
import { FranchiseService } from '../../../services/http/franchise.service';

@Component({
  selector: 'app-create-medium',
  templateUrl: './create-medium.component.html'
})
export class CreateMediumComponent implements OnDestroy {
  @Output() setViewMode = new EventEmitter<void>()

  #franchiseService = inject(FranchiseService)
  #formBuilder = inject(FormBuilder)

  #destroy$ = new Subject<void>()

  public formGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public createMedium(): void {
    let form: MediumCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
    }

    if (this.formGroup.valid) {
      this.#franchiseService.createMedium(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe((response) => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.createMedium()
        break
    }
  }
}