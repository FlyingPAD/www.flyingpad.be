import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { TagFull } from '../../../interfaces/tag';
import { FlowService } from '../../../services/flow.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-tag',
  templateUrl: './delete-tag.component.html',
  styleUrl: './delete-tag.component.scss'
})
export class DeleteTagComponent {
  @Input() tag!: TagFull | undefined
  @Input() tagCategoryId: number | undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public deleteTag(): void {
    if (this.tag && this.tagCategoryId) {
      this.#subscription = this.#flowService.DeleteTag(this.tag.businessId, this.tagCategoryId).subscribe(
        (response) => { if (response.success) this.toggleDialog.emit() })
    }
  }
}