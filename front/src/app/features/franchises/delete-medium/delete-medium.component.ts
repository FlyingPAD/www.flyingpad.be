import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { MediumFull } from '../../../interfaces/franchise';
import { Subscription } from 'rxjs';
import { MediumService } from '../../../services/http/medium.service';

@Component({
  selector: 'app-delete-medium',
  templateUrl: './delete-medium.component.html',
  styleUrl: './delete-medium.component.scss'
})
export class DeleteMediumComponent implements OnDestroy {
  @Input() medium: MediumFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #mediumService = inject(MediumService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public delete(): void {
    if (this.medium) {
      this.#subscription = this.#mediumService.deleteMedium(this.medium.businessId).subscribe(
        (response) => { if (response.success) this.toggleDialog.emit() })
    }
  }
}