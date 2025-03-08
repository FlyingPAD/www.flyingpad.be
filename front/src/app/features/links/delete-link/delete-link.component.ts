import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { LinkFull } from '../../../interfaces/link';
import { Subscription } from 'rxjs';
import { LinkService } from '../../../services/http/link.service';

@Component({
  selector: 'app-delete-link',
  templateUrl: './delete-link.component.html',
  styleUrl: './delete-link.component.scss'
})
export class DeleteLinkComponent implements OnDestroy {
  @Input() link : LinkFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #linkService = inject(LinkService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }
  
  public delete(): void {
    if(this.link) {
      this.#subscription = this.#linkService.deleteLink(this.link.businessId).subscribe(
        (response) => {if(response.success) this.toggleDialog.emit()})
    }
  }
}