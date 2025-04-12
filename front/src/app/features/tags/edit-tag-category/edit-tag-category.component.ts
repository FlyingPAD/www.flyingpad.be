import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { TagCategoryFull } from '../../../interfaces/tag';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { TagCategoryUpdateForm } from '../../../interfaces/forms-update';
import { TagService } from '../../../services/http/tag.service';

@Component({
  selector: 'app-edit-tag-category',
  templateUrl: './edit-tag-category.component.html'
})
export class EditTagCategoryComponent implements OnInit, OnDestroy {
  @Input() tagCategory: TagCategoryFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #tagService = inject(TagService)
  #formBuilder = inject(FormBuilder)

  #destroy$ = new Subject<void>()

  public isDeleteDialogOpen: boolean = false
  public editFormGroup!: FormGroup


  ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group({
      name: [this.tagCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.tagCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
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
    let form: TagCategoryUpdateForm = {
      tagCategoryId: this.tagCategory ? this.tagCategory.businessId : 0,
      name: this.editFormGroup.value.name,
      description: this.editFormGroup.value.description
    }

    if (this.editFormGroup.valid) {
      this.#tagService.updateTagCategory(form)
      .pipe(takeUntil(this.#destroy$))
      .subscribe(() => this.setViewMode.emit())
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