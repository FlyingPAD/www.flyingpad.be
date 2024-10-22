import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ArtistFull } from '../../../interfaces/artist';
import { FlowService } from '../../../services/flow.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-delete-artist',
  templateUrl: './delete-artist.component.html',
  styleUrl: './delete-artist.component.scss'
})
export class DeleteArtistComponent {
  @Input() artist : ArtistFull | undefined = undefined
  @Output() toggleDialog = new EventEmitter<void>()

  #flowService = inject(FlowService)

  subscription = new Subscription()

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }
  delete(): void {
    if(this.artist) {
      this.subscription = this.#flowService.DeleteArtist(this.artist.businessId).subscribe(
        (response) => {if(response.success) this.toggleDialog.emit()})
    }
  }
}