import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { TagFull } from '../../../models/tag';
import { FlowService } from '../../../services/flow.service';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-tag',
  templateUrl: './delete-tag.component.html',
  styleUrl: './delete-tag.component.scss'
})
export class DeleteTagComponent {
  @Input() tag! : TagFull | undefined
  @Input() tagCategoryId : number | undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #toastr = inject(ToastrService)

  subscription = new Subscription()

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }
  deleteTag(): void {
    if(this.tag && this.tagCategoryId) {
      this.subscription = this.#flowService.DeleteTag(this.tag.businessId, this.tagCategoryId).subscribe({
        next : (response) => {
          if(response.success) {
            this.#toastr.success('Tag was deleted.')
            this.toggleDialog.emit()
          }
        },
        error : (error) => {
          this.#toastr.error('Error : ' + error.message)
        }
      })
    }
  }
}