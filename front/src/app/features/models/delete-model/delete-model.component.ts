import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { ModelFull } from '../../../models/model';
import { Subscription } from 'rxjs';
import { FlowService } from '../../../services/flow.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-delete-model',
  templateUrl: './delete-model.component.html',
  styleUrl: './delete-model.component.scss'
})
export class DeleteModelComponent implements OnDestroy {
  @Input() model! : ModelFull | undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #toastr = inject(ToastrService)

  subscription = new Subscription()

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }
  deleteModel(): void {
    if(this.model) {
      this.subscription = this.#flowService.DeleteModel(this.model?.businessId).subscribe({
        next : (response) => {
          if(response.success) {
            this.#toastr.success('Model was deleted.')
            this.toggleDialog.emit()
          }
        },
        error : (error) => {
          this.#toastr.error('Error : ' + error.message)
        }
      })
    }
  }
}