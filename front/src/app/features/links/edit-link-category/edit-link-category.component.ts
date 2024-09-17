import { Component, EventEmitter, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { LinkCategoryFull } from '../../../models/link';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { LinkCategoryUpdateForm } from '../../../models/forms-update';

@Component({
  selector: 'app-edit-link-category',
  templateUrl: './edit-link-category.component.html',
  styleUrl: './edit-link-category.component.scss'
})
export class EditLinkCategoryComponent implements OnInit, OnDestroy{
  @Input() linkCategory : LinkCategoryFull | undefined = undefined
  @Output() showListTrigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  
  subscription = new Subscription()
  isDeleteDialogOpen : boolean = false
  
  editFormGroup! : FormGroup

  ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group({
      name: [this.linkCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.linkCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
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
    let form : LinkCategoryUpdateForm = {
      linkCategoryId : this.linkCategory? this.linkCategory.businessId : 0,
      name : this.editFormGroup.value.name,
      description : this.editFormGroup.value.description
    }

    if(this.editFormGroup.valid) {
      this.subscription = this.#flowService.UpdateLinkCategory(form).subscribe({
        next : (response) => {
          if(response.success) this.showListTrigger.emit()
        }
      })
    }
  }
}