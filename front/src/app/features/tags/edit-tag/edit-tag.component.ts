import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { TagFull } from '../../../interfaces/tag';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { TagUpdateForm } from '../../../interfaces/http/forms-update';
import { TagCategoryLight } from '../../../interfaces/tag';
import { TagService } from '../../../services/http/tag.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-tag',
  templateUrl: './edit-tag.component.html'
})
export class EditTagComponent implements OnInit, OnDestroy {
  #tagService = inject(TagService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() tag: TagFull | undefined = undefined
  @Input() tagCategories: TagCategoryLight[] = []

  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup!: FormGroup


  ngOnInit(): void {
    this.formGroup = this.#formBuilder.group({
      name: [this.tag?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.tag?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      tagCategoryId: [this.tag?.tagCategoryId, Validators.required]
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }


  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateTag(): void {
    let form: TagUpdateForm = {
      tagId: this.tag ? this.tag.businessId : 0,
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
      tagCategoryId: this.formGroup.value.tagCategoryId
    }

    if (this.formGroup.valid) {
      this.#tagService.updateTag(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => {
          if (response.success) this.setViewMode.emit()
        })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateTag()
        break
    }
  }
}