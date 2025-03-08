import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { LinkCategoryFull } from '../../../interfaces/link';
import { Subscription } from 'rxjs';
import { LinkCategoryService } from '../../../services/http/link-category.service';

@Component({
  selector: 'app-delete-link-category',
  templateUrl: './delete-link-category.component.html',
  styleUrl: './delete-link-category.component.scss'
})
export class DeleteLinkCategoryComponent implements OnDestroy {
  @Input() linkCategory: LinkCategoryFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #linkCategoryService = inject(LinkCategoryService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public delete(): void {
    if (this.linkCategory != undefined) {
      this.#subscription = this.#linkCategoryService.deleteLinkCategory(this.linkCategory.businessId).subscribe(
        (response) => { if (response.success) this.toggleDialog.emit() })
    }
  }
}