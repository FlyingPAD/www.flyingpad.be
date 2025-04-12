import { Component, inject, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-bottom-icon-model',
  templateUrl: './bottom-icon-model.component.html'
})

export class BottomIconModelComponent {
  #router = inject(Router)

  @Input() page: string | undefined

  public GoTo(page: string): void {
    this.#router.navigateByUrl(page)
  }
}