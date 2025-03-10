import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { StyleFull } from '../../../interfaces/style';
import { Subscription } from 'rxjs';
import { StyleService } from '../../../services/http/style.service';

@Component({
  selector: 'app-delete-style',
  templateUrl: './delete-style.component.html',
  styleUrl: './delete-style.component.scss'
})
export class DeleteStyleComponent implements OnDestroy {
  @Input() style: StyleFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #styleService = inject(StyleService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }
  delete(): void {
    if(this.style != undefined) {
      this.#subscription = this.#styleService.deleteStyle(this.style.businessId).subscribe(
        (response) => { if(response.success) this.toggleDialog.emit() })
    }
  }
}