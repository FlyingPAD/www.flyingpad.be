import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { TagFull } from '../../../interfaces/tag';
import { Subject, takeUntil } from 'rxjs';
import { TagService } from '../../../services/http/tag.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-tag',
  templateUrl: './delete-tag.component.html'
})
export class DeleteTagComponent implements OnDestroy {
  #tagService = inject(TagService)
  #dialogService = inject(DialogService)

  @Input() tag!: TagFull | undefined
  @Input() tagCategoryId: number | undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()
  

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteTag(): void {
    if (this.tag && this.tagCategoryId) {
      this.#tagService.deleteTag(this.tag.businessId)
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