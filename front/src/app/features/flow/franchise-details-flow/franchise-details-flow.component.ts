import { Component, inject, Input } from '@angular/core';
import { FranchiseFull } from '../../../models/franchise';
import { FranchiseUpdateForm } from '../../../models/forms-update';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-franchise-details-flow',
  templateUrl: './franchise-details-flow.component.html',
  styleUrl: './franchise-details-flow.component.scss'
})
export class FranchiseDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() franchise! : FranchiseFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.franchise?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.franchise?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
  })

  update(): void {
    if (this.franchise && this.formGroup.valid) 
    {  
      let form : FranchiseUpdateForm = 
      {
       franchiseId : this.franchise?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description,
       mediaIds : []
      }
      this.#flowService.UpdateFranchise(form).subscribe({
        next: () => {
          this.#toastr.success('Franchise successfully updated.')
        },
        error: (error) => {
          this.#toastr.error('Error : ' + error);
        }
      })
    }
    this.formGroup.reset()
  }

  triggerDeleteDialog(): void {
    this.triggerDelete = !this.triggerDelete
  }

  delete(): void { 
    if(this.franchise)
      {
        this.#flowService.DeleteLink(this.franchise?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Franchise successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}