import { Component, EventEmitter, HostListener, inject, OnDestroy, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { LinkCategoryCreateForm } from '../../../interfaces/forms-create';
import { LinkService } from '../../../services/http/link.service';

@Component({
  selector: 'app-create-link-category',
  templateUrl: './create-link-category.component.html'
})
export class CreateLinkCategoryComponent implements OnDestroy {
  #linkService = inject(LinkService)
  #formBuilder = inject(FormBuilder)

  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public createLinkCategory(): void {
    let form: LinkCategoryCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
    }

    if (this.formGroup.valid) {
      this.#linkService.createLinkCategory(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.createLinkCategory()
        break
    }
  }
}