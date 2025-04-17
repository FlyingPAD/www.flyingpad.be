import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { LinkCategoryFull } from '../../../interfaces/link';
import { Subject, takeUntil } from 'rxjs';
import { LinkService } from '../../../services/http/link.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-link-category',
  templateUrl: './delete-link-category.component.html'
})
export class DeleteLinkCategoryComponent implements OnDestroy {
  #linkService = inject(LinkService)
  #dialogService = inject(DialogService)

  @Input() linkCategory: LinkCategoryFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()


  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteLinkCategory(): void {
    if (this.linkCategory) {
      this.#linkService.deleteLinkCategory(this.linkCategory.businessId)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => {
          if (response.success) {
            this.#dialogService.toggleDialog()
            this.setViewMode.emit()
          }
        })
    }
  }
}