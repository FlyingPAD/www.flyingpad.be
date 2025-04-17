import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { TagCategoryFull } from '../../../interfaces/tag';
import { Subject, takeUntil } from 'rxjs';
import { TagService } from '../../../services/http/tag.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-tag-category',
  templateUrl: './delete-tag-category.component.html'
})
export class DeleteTagCategoryComponent implements OnDestroy {
  #tagService = inject(TagService)
  #dialogService = inject(DialogService)

  @Input() tagCategory: TagCategoryFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()


  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteTagCategory(): void {
    if (this.tagCategory) {
      this.#tagService.deleteTagCategory(this.tagCategory.businessId)
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