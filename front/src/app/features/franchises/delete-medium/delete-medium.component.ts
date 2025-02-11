import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { MediumFull } from '../../../interfaces/franchise';
import { FlowService } from '../../../services/flow.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-medium',
  templateUrl: './delete-medium.component.html',
  styleUrl: './delete-medium.component.scss'
})
export class DeleteMediumComponent {
  @Input() medium: MediumFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public delete(): void {
    if (this.medium) {
      this.#subscription = this.#flowService.DeleteMedium(this.medium.businessId).subscribe(
        (response) => { if (response.success) this.toggleDialog.emit() })
    }
  }
}