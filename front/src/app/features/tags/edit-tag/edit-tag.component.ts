import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { TagFull } from '../../../models/tag';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { TagUpdateForm } from '../../../models/forms-update';
import { FlowService } from '../../../services/flow.service';
import { TagCategoryLight } from '../../../models/tag-category';

@Component({
  selector: 'app-edit-tag',
  templateUrl: './edit-tag.component.html',
  styleUrl: './edit-tag.component.scss'
})
export class EditTagComponent implements OnInit {
  @Input() tag! : TagFull | undefined
  @Input() tagCategories! : TagCategoryLight[]
  @Output() showListTrigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  
  subscription = new Subscription()
  isDeleteDialogOpen : boolean = false
  
  editFormGroup! : FormGroup

  ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group({
      name: [this.tag?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.tag?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      tagCategoryId: [this.tag?.tagCategoryId, Validators.required]
    });
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
    let form : TagUpdateForm = {
      tagId : this.tag? this.tag.businessId : 0,
      name : this.editFormGroup.value.name,
      description : this.editFormGroup.value.description,
      tagCategoryId : this.editFormGroup.value.tagCategoryId
    }

    if(this.editFormGroup.valid) {
      this.subscription = this.#flowService.UpdateTag(form).subscribe({
        next : () => {
          this.#toastr.success('Success !')
          this.showListTrigger.emit()
        }
      })
    }
  }
}