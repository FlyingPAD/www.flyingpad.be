import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { LinkFull } from '../../../models/link';
import { FlowService } from '../../../services/flow.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-link',
  templateUrl: './delete-link.component.html',
  styleUrl: './delete-link.component.scss'
})
export class DeleteLinkComponent {
  @Input() link : LinkFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)

  subscription = new Subscription()

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }
  delete(): void {
    if(this.link) {
      this.subscription = this.#flowService.DeleteLink(this.link.businessId).subscribe(
        (response) => {if(response.success) this.toggleDialog.emit()})
    }
  }
}