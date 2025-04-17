import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { TagCategoryFull } from '../../../interfaces/tag';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { TagCategoryUpdateForm } from '../../../interfaces/forms-update';
import { TagService } from '../../../services/http/tag.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-tag-category',
  templateUrl: './edit-tag-category.component.html'
})
export class EditTagCategoryComponent implements OnInit, OnDestroy {
  #tagService = inject(TagService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() tagCategory: TagCategoryFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup!: FormGroup


  ngOnInit(): void {
    this.formGroup = this.#formBuilder.group({
      name: [this.tagCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.tagCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateTagCategory(): void {
    let form: TagCategoryUpdateForm = {
      tagCategoryId: this.tagCategory ? this.tagCategory.businessId : 0,
      name: this.formGroup.value.name,
      description: this.formGroup.value.description
    }

    if (this.formGroup.valid) {
      this.#tagService.updateTagCategory(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(() => this.setViewMode.emit())
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateTagCategory()
        break
    }
  }
}