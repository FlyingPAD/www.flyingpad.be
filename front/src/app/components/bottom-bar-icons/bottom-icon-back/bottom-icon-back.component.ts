import { Component, inject, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-bottom-icon-back',
  templateUrl: './bottom-icon-back.component.html'
})
export class BottomIconBackComponent {
  #router = inject(Router)

  @Input() page: string | undefined

  public goTo(page: string): void {
    this.#router.navigateByUrl(page)
  }
}