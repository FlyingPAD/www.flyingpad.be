import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { LinkFull } from '../../../interfaces/link';
import { Subject, takeUntil } from 'rxjs';
import { LinkService } from '../../../services/http/link.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-link',
  templateUrl: './delete-link.component.html'
})
export class DeleteLinkComponent implements OnDestroy {
  #linkService = inject(LinkService)
  #dialogService = inject(DialogService)

  @Input() link: LinkFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()
  

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteLink(): void {
    if (this.link) {
      this.#linkService.deleteLink(this.link.businessId)
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