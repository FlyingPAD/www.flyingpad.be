import { Component, EventEmitter, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { TagCategoryFull } from '../../../models/tag-category';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { TagCategoryUpdateForm } from '../../../models/forms-update';

@Component({
  selector: 'app-edit-tag-category',
  templateUrl: './edit-tag-category.component.html',
  styleUrl: './edit-tag-category.component.scss'
})
export class EditTagCategoryComponent implements OnInit, OnDestroy {
  @Input() tagCategory : TagCategoryFull | undefined = undefined
  @Output() showListTrigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  
  subscription = new Subscription()
  isDeleteDialogOpen : boolean = false
  
  editFormGroup! : FormGroup

  ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group({
      name: [this.tagCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.tagCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }

  openDeleteDialog(): void {
    this.isDeleteDialogOpen = true
  }
  closeDeleteDialog(): void {
    this.isDeleteDialogOpen = false
  }
  closeDeleteDialogEmit(): void {
    this.isDeleteDialogOpen = false
    this.showListTrigger.emit()
  }

  onSubmit() : void {
    let form : TagCategoryUpdateForm = {
      tagCategoryId : this.tagCategory? this.tagCategory.businessId : 0,
      name : this.editFormGroup.value.name,
      description : this.editFormGroup.value.description
    }

    if(this.editFormGroup.valid) {
      this.subscription = this.#flowService.UpdateTagCategory(form).subscribe({
        next : () => {
          this.showListTrigger.emit()
        }
      })
    }
  }
}