import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { ModelFull } from '../../../interfaces/model';
import { Subscription } from 'rxjs';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-delete-model',
  templateUrl: './delete-model.component.html',
  styleUrl: './delete-model.component.scss'
})
export class DeleteModelComponent implements OnDestroy {
  @Input() model : ModelFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)

  subscription = new Subscription()

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }
  
  deleteModel(): void {
    if(this.model) {
      this.subscription = this.#flowService.DeleteModel(this.model?.businessId).subscribe({
        next : (response) => {
          if(response.success) {
            this.toggleDialog.emit()
          }
        }
      })
    }
  }
}