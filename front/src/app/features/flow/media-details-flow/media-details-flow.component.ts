import { Component, inject, Input } from '@angular/core';
import { MediumFull } from '../../../models/franchise';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { FlowService } from '../../../services/flow.service';
import { MediumUpdateForm } from '../../../models/forms-update';

@Component({
  selector: 'app-media-details-flow',
  templateUrl: './media-details-flow.component.html',
  styleUrl: './media-details-flow.component.scss'
})
export class MediaDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() medium!: MediumFull | undefined
  triggerDelete: boolean = false

  formGroup: FormGroup = this.#formBuilder.group
    ({
      name: [this.medium?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.medium?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    })

  update(): void {
    if (this.medium && this.formGroup.valid) {
      let form: MediumUpdateForm = {
        mediumId: this.medium?.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description,
      }
      this.#flowService.UpdateMedium(form).subscribe()
    }
    this.formGroup.reset()
  }

  triggerDeleteDialog(): void {
    this.triggerDelete = !this.triggerDelete
  }

  delete(): void {
    if (this.medium) {
      this.#flowService.DeleteMedium(this.medium?.businessId).subscribe()
    }
  }
}