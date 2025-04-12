import { Component, EventEmitter, HostListener, inject, OnDestroy, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { TagCategoryCreateForm } from '../../../interfaces/forms-create';
import { TagService } from '../../../services/http/tag.service';

@Component({
  selector: 'app-create-tag-category',
  templateUrl: './create-tag-category.component.html',
  styleUrl: './create-tag-category.component.scss'
})
export class CreateTagCategoryComponent implements OnDestroy {
  @Output() setViewMode = new EventEmitter<void>()

  #tagService = inject(TagService)
  #formBuilder = inject(FormBuilder)

  createFormGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  #destroy$ = new Subject<void>()


  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public onSubmit(): void {
    let form: TagCategoryCreateForm = {
      name: this.createFormGroup.value.name,
      description: this.createFormGroup.value.description,
    }

    if (this.createFormGroup.valid) {
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