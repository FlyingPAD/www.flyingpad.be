import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { FranchiseFull } from '../../../interfaces/franchise';
import { Subject, takeUntil } from 'rxjs';
import { FranchiseService } from '../../../services/http/franchise.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-franchise',
  templateUrl: './delete-franchise.component.html'
})
export class DeleteFranchiseComponent implements OnDestroy {
  #franchiseService = inject(FranchiseService)
  #dialogService = inject(DialogService)

  @Input() franchise: FranchiseFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteFranchise(): void {
    if (this.franchise) {
      this.#franchiseService.deleteFranchise(this.franchise.businessId)
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