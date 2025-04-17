import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { ModelFull } from '../../../interfaces/model';
import { Subject, takeUntil } from 'rxjs';
import { ModelService } from '../../../services/http/model.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-model',
  templateUrl: './delete-model.component.html'
})
export class DeleteModelComponent implements OnDestroy {
  #modelService = inject(ModelService)
  #dialogService = inject(DialogService)

  @Input() model: ModelFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteModel(): void {
    if (this.model) {
      this.#modelService.deleteModel(this.model?.businessId)
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