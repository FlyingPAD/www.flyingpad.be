import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { TagCategoryFull } from '../../../models/tag-category';
import { FlowService } from '../../../services/flow.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-tag-category',
  templateUrl: './delete-tag-category.component.html',
  styleUrl: './delete-tag-category.component.scss'
})
export class DeleteTagCategoryComponent implements OnDestroy {
  @Input() tagCategory! : TagCategoryFull | undefined
  @Input() tagCategoryId : number | undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)

  subscription = new Subscription()

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }
  deleteTagCategory(): void {
    if(this.tagCategory) {
      this.subscription = this.#flowService.DeleteTagCategory(this.tagCategory.businessId).subscribe({
        next : (response) => {
          if(response.success) {
            this.toggleDialog.emit()
          }
        }
      })
    }
  }
}