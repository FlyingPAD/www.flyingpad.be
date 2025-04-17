import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { ArtistService } from '../../../services/http/artist.service';
import { StyleFull } from '../../../interfaces/artist';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-style',
  templateUrl: './delete-style.component.html'
})
export class DeleteStyleComponent implements OnDestroy {
  #artistService = inject(ArtistService)
  #dialogService = inject(DialogService)

  @Input() style: StyleFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteStyle(): void {
    if (this.style) {
      this.#artistService.deleteStyle(this.style.businessId)
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