import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { TagFull } from '../../../interfaces/tag';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { TagUpdateForm } from '../../../interfaces/forms-update';
import { TagCategoryLight } from '../../../interfaces/tag-category';
import { TagService } from '../../../services/http/tag.service';

@Component({
  selector: 'app-edit-tag',
  templateUrl: './edit-tag.component.html',
  styleUrl: './edit-tag.component.scss'
})
export class EditTagComponent implements OnInit, OnDestroy {
  @Input() tag: TagFull | undefined = undefined
  @Input() tagCategories: TagCategoryLight[] = []
  @Output() showListTrigger = new EventEmitter<void>()

  #tagService = inject(TagService)
  #formBuilder = inject(FormBuilder)

  #subscription = new Subscription()

  public isDeleteDialogOpen: boolean = false
  public editFormGroup!: FormGroup

  ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group({
      name: [this.tag?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.tag?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      tagCategoryId: [this.tag?.tagCategoryId, Validators.required]
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
    let form: TagUpdateForm = {
      tagId: this.tag ? this.tag.businessId : 0,
      name: this.editFormGroup.value.name,
      description: this.editFormGroup.value.description,
      tagCategoryId: this.editFormGroup.value.tagCategoryId
    }

    if (this.editFormGroup.valid) {
      this.#subscription = this.#tagService.updateTag(form).subscribe(response => {
        if(response.success) this.showListTrigger.emit() })
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