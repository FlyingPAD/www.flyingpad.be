import { Component, EventEmitter, inject, Input, OnDestroy, Output } from '@angular/core';
import { Subscription } from 'rxjs';
import { ArtistService } from '../../../services/http/artist.service';
import { StyleFull } from '../../../interfaces/artist';

@Component({
  selector: 'app-delete-style',
  templateUrl: './delete-style.component.html',
  styleUrl: './delete-style.component.scss'
})
export class DeleteStyleComponent implements OnDestroy {
  @Input() style: StyleFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #artistService = inject(ArtistService)

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }
  delete(): void {
    if(this.style != undefined) {
      this.#subscription = this.#artistService.deleteStyle(this.style.businessId).subscribe(
        (response) => { if(response.success) this.toggleDialog.emit() })
    }
  }
}