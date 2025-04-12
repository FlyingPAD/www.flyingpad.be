import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { MediumFull } from '../../../interfaces/franchise';
import { Subscription } from 'rxjs';
import { FranchiseService } from '../../../services/http/franchise.service';

@Component({
  selector: 'app-delete-medium',
  templateUrl: './delete-medium.component.html',
  styleUrl: './delete-medium.component.scss'
})
export class DeleteMediumComponent implements OnDestroy {
  @Input() medium: MediumFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #franchiseService = inject(FranchiseService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public delete(): void {
    if (this.medium) {
      this.#subscription = this.#franchiseService.deleteMedium(this.medium.businessId).subscribe(
        (response) => { if (response.success) this.toggleDialog.emit() })
    }
  }
}