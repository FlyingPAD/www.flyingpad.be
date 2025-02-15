import { Directive, ElementRef, inject, Input, OnChanges, SimpleChanges } from '@angular/core';

@Directive({
  selector: '[appScrollActive]'
})
export class ScrollDirective implements OnChanges {
  #elementReference = inject(ElementRef)

  @Input() appScrollActive!: boolean
  @Input() scrollPosition: 'center' | 'top' = 'center'
  @Input() scrollOffset: number = 0
  

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['appScrollActive'] && this.appScrollActive === true) {
      requestAnimationFrame(() => {
        if (this.scrollPosition === 'top' && this.scrollOffset) {
          const elementRect = this.#elementReference.nativeElement.getBoundingClientRect()
          const elementTop = elementRect.top + window.scrollY
          const targetScrollY = elementTop - this.scrollOffset
          window.scrollTo({
            top: targetScrollY,
            behavior: 'smooth'
          })
        } else {
          this.#elementReference.nativeElement.scrollIntoView({
            behavior: 'smooth',
            block: this.scrollPosition === 'top' ? 'start' : 'center',
            inline: 'nearest'
          })
        }
      })
    }
  }
}