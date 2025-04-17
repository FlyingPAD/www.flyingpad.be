import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { TagCreateForm } from '../../../interfaces/forms-create';
import { TagCategoryFull, TagCategoryLight } from '../../../interfaces/tag';
import { TagService } from '../../../services/http/tag.service';

@Component({
  selector: 'app-create-tag',
  templateUrl: './create-tag.component.html'
})
export class CreateTagComponent implements OnInit, OnDestroy {
  #tagService = inject(TagService)
  #formBuilder = inject(FormBuilder)

  @Input() tagCategories!: TagCategoryLight[]
  @Input() category: TagCategoryFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    tagCategoryId: [0]
  })

  ngOnInit(): void {
    if (this.category) {
      this.formGroup.patchValue({ tagCategoryId: this.category.businessId })
    }
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public createTag(): void {
    let form: TagCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
      tagCategoryId: this.formGroup.value.tagCategoryId
    }

    if (this.formGroup.valid) {
      this.#tagService.createTag(form)
      .pipe(takeUntil(this.#destroy$))
      .subscribe(() => this.setViewMode.emit())    
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.createTag()
        break
    }
  }
}