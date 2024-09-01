import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { ModelFull } from '../../../models/model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ModelUpdateForm } from '../../../models/forms-update';
import { FlowService } from '../../../services/flow.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-edit-model',
  templateUrl: './edit-model.component.html',
  styleUrl: './edit-model.component.scss'
})
export class EditModelComponent implements OnInit {
  @Input() model! : ModelFull | undefined
  @Output() showListTrigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)

  subscription = new Subscription()
  isDeleteDialogOpen : boolean = false

  editFormGroup! : FormGroup

  ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group
    ({
      pseudonym : [this.model?.pseudonym, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      firstName : [this.model?.firstName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      lastName : [this.model?.lastName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      gender : [this.model?.gender, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description : [this.model?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
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

  onSubmit(): void {
    let form : ModelUpdateForm = {
      modelId : this.model? this.model.businessId : 0,
      pseudonym : this.editFormGroup.value.pseudonym,
      firstName : this.editFormGroup.value.firstName,
      lastName : this.editFormGroup.value.lastName,
      gender : this.editFormGroup.value.gender,
      description : this.editFormGroup.value.description,
    }

    if(this.editFormGroup.valid) {
      this.subscription = this.#flowService.UpdateModel(form).subscribe({
        next : () => {
          this.#toastr.success('Model was updated.')
        }
      })
    }
  }
}