import { Directive, HostListener, inject } from '@angular/core';
import { Location } from '@angular/common';

@Directive({
  selector: '[appGoBack]'
})
export class GoBackDirective {
  #location = inject(Location)

  @HostListener('click')
  onClick(): void {
    this.#location.back()
  }
}