import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { TagCategoryFull } from '../../../interfaces/tag';
import { Subscription } from 'rxjs';
import { TagService } from '../../../services/http/tag.service';

@Component({
  selector: 'app-delete-tag-category',
  templateUrl: './delete-tag-category.component.html',
  styleUrl: './delete-tag-category.component.scss'
})
export class DeleteTagCategoryComponent implements OnDestroy {
  @Input() tagCategory: TagCategoryFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #tagService = inject(TagService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public deleteTagCategory(): void {
    if (this.tagCategory != undefined) {
      this.#subscription = this.#tagService.deleteTagCategory(this.tagCategory.businessId).subscribe(
        (response) => { if (response.success) this.toggleDialog.emit() })
    }
  }
}