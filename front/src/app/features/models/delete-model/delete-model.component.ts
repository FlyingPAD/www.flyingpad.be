import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { ModelFull } from '../../../interfaces/model';
import { Subscription } from 'rxjs';
import { ModelService } from '../../../services/http/model.service';

@Component({
  selector: 'app-delete-model',
  templateUrl: './delete-model.component.html',
  styleUrl: './delete-model.component.scss'
})
export class DeleteModelComponent implements OnDestroy {
  @Input() model : ModelFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #modelService = inject(ModelService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }
  
  public deleteModel(): void {
    if(this.model) {
      this.#subscription = this.#modelService.deleteModel(this.model?.businessId).subscribe(response => {
        if(response.success) this.toggleDialog.emit() })
    }
  }
}