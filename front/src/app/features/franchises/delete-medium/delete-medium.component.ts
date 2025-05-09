import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { MediumFull } from '../../../interfaces/franchise';
import { Subject, takeUntil } from 'rxjs';
import { FranchiseService } from '../../../services/http/franchise.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-medium',
  templateUrl: './delete-medium.component.html'
})
export class DeleteMediumComponent implements OnDestroy {
  #franchiseService = inject(FranchiseService)
  #dialogService = inject(DialogService)

  @Input() medium: MediumFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteMedium(): void {
    if (this.medium) {
      this.#franchiseService.deleteMedium(this.medium.businessId)
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