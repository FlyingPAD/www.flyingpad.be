import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { TagCategoryFull } from '../../../interfaces/tag-category';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { TagCategoryUpdateForm } from '../../../interfaces/forms-update';
import { TagCategoryService } from '../../../services/http/tag-category.service';

@Component({
  selector: 'app-edit-tag-category',
  templateUrl: './edit-tag-category.component.html',
  styleUrl: './edit-tag-category.component.scss'
})
export class EditTagCategoryComponent implements OnInit, OnDestroy {
  @Input() tagCategory: TagCategoryFull | undefined = undefined
  @Output() showListTrigger = new EventEmitter<void>()

  #tagCategoryService = inject(TagCategoryService)
  #formBuilder = inject(FormBuilder)

  #subscription = new Subscription()

  public isDeleteDialogOpen: boolean = false
  public editFormGroup!: FormGroup


  ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group({
      name: [this.tagCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.tagCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
  }

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public openDeleteDialog(): void {
    this.isDeleteDialogOpen = true
  }
  public closeDeleteDialog(): void {
    this.isDeleteDialogOpen = false
  }
  public closeDeleteDialogEmit(): void {
    this.isDeleteDialogOpen = false
    this.showListTrigger.emit()
  }

  public onSubmit(): void {
    let form: TagCategoryUpdateForm = {
      tagCategoryId: this.tagCategory ? this.tagCategory.businessId : 0,
      name: this.editFormGroup.value.name,
      description: this.editFormGroup.value.description
    }

    if (this.editFormGroup.valid) {
      this.#subscription = this.#tagCategoryService.updateTagCategory(form).subscribe({
        next: () => {
          this.showListTrigger.emit()
        }
      })
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