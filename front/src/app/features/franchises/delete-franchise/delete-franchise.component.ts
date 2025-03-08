import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { FranchiseFull } from '../../../interfaces/franchise';
import { Subscription } from 'rxjs';
import { FranchiseService } from '../../../services/http/franchise.service';

@Component({
  selector: 'app-delete-franchise',
  templateUrl: './delete-franchise.component.html',
  styleUrl: './delete-franchise.component.scss'
})
export class DeleteFranchiseComponent implements OnDestroy {
  @Input() franchise : FranchiseFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #franchiseService = inject(FranchiseService)

  #subscription = new Subscription()  

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public deleteLink(): void {
    if(this.franchise) {
      this.#subscription = this.#franchiseService.deleteFranchise(this.franchise.businessId).subscribe(
        (response) => {if(response.success) this.toggleDialog.emit()})
    }
  }
}