import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { TagFull } from '../../../interfaces/tag';
import { Subscription } from 'rxjs';
import { TagService } from '../../../services/http/tag.service';

@Component({
  selector: 'app-delete-tag',
  templateUrl: './delete-tag.component.html',
  styleUrl: './delete-tag.component.scss'
})
export class DeleteTagComponent implements OnDestroy {
  @Input() tag!: TagFull | undefined
  @Input() tagCategoryId: number | undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #tagService = inject(TagService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public deleteTag(): void {
    if (this.tag && this.tagCategoryId) {
      this.#subscription = this.#tagService.deleteTag(this.tag.businessId).subscribe(
        (response) => { if (response.success) this.toggleDialog.emit() })
    }
  }
}