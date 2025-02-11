import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { FranchiseFull } from '../../../interfaces/franchise';
import { FlowService } from '../../../services/flow.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-franchise',
  templateUrl: './delete-franchise.component.html',
  styleUrl: './delete-franchise.component.scss'
})
export class DeleteFranchiseComponent implements OnDestroy {
  @Input() franchise : FranchiseFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)

  #subscription = new Subscription()
  

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public deleteLink(): void {
    if(this.franchise) {
      this.#subscription = this.#flowService.DeleteFranchise(this.franchise.businessId).subscribe(
        (response) => {if(response.success) this.toggleDialog.emit()})
    }
  }
}