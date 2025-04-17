import { Component, EventEmitter, HostListener, inject, OnDestroy, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { TagCategoryCreateForm } from '../../../interfaces/forms-create';
import { TagService } from '../../../services/http/tag.service';

@Component({
  selector: 'app-create-tag-category',
  templateUrl: './create-tag-category.component.html'
})
export class CreateTagCategoryComponent implements OnDestroy {
  #tagService = inject(TagService)
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

  public onSubmit(): void {
    let form: TagCategoryCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
    }

    if (this.formGroup.valid) {
      this.#tagService.createTagCategory(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => { if (response.success) this.setViewMode.emit() })
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