import { Directive, ElementRef, HostListener, inject, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appAnimRotation360]'
})
export class AnimRotation360Directive {
  #elementRef = inject(ElementRef)
  #renderer = inject(Renderer2)

  @HostListener('click')
  onClick() {
    const element = this.#elementRef.nativeElement

    this.#renderer.addClass(element, 'animate-rotate')

    element.addEventListener('animationend', () => {
      this.#renderer.removeClass(element, 'animate-rotate')
    }, { once: true })
  }
}