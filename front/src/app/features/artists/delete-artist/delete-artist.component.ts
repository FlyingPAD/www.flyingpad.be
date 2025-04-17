import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { ArtistFull } from '../../../interfaces/artist';
import { Subject, takeUntil } from 'rxjs';
import { ArtistService } from '../../../services/http/artist.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-delete-artist',
  templateUrl: './delete-artist.component.html'
})
export class DeleteArtistComponent {
  #artistService = inject(ArtistService)
  #dialogService = inject(DialogService)

  @Input() artist: ArtistFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public deleteArtist(): void {
    if (this.artist) {
      this.#artistService.deleteArtist(this.artist.businessId)
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