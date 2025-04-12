import { Component, inject, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-bottom-icon-artist',
  templateUrl: './bottom-icon-artist.component.html'
})

export class BottomIconArtistComponent {
  #router = inject(Router)

  @Input() page: string | undefined

  public GoTo(page: string): void {
    this.#router.navigateByUrl(page)
  }
}