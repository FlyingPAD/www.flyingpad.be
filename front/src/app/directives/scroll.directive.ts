import { Directive, ElementRef, inject, Input, OnChanges, SimpleChanges } from '@angular/core';

@Directive({
  selector: '[appScrollActive]'
})
export class ScrollDirective implements OnChanges {
  elementReference = inject(ElementRef)
  @Input() appScrollActive!: boolean

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['appScrollActive'] && this.appScrollActive === true) {
      requestAnimationFrame(() => {
        this.elementReference.nativeElement.scrollIntoView({
          behavior: 'smooth',
          block: 'center',
          inline: 'nearest'
        })
      })
    }
  }
}