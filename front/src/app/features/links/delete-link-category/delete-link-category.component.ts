import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { LinkCategoryFull } from '../../../models/link';
import { FlowService } from '../../../services/flow.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-link-category',
  templateUrl: './delete-link-category.component.html',
  styleUrl: './delete-link-category.component.scss'
})
export class DeleteLinkCategoryComponent implements OnDestroy {
  @Input() linkCategory : LinkCategoryFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)

  subscription = new Subscription()

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }
  deleteLinkCategory(): void {
    if(this.linkCategory != undefined) {
      this.subscription = this.#flowService.DeleteLinkCategory(this.linkCategory.businessId).subscribe({
        next : (response) => {
          if(response.success) {
            this.toggleDialog.emit()
          }
        }
      })
    }
  }
}