import { Directive, ElementRef, HostListener, Renderer2, inject } from '@angular/core';

@Directive({
  selector: '[appAnimSpin]'
})
export class AnimSpinDirective {
  #elementRef = inject(ElementRef)
  #renderer = inject(Renderer2)

  @HostListener('click')
  onClick() {
    const element = this.#elementRef.nativeElement

    this.#renderer.addClass(element, 'animate-spin')

    element.addEventListener('animationend', () => {
      this.#renderer.removeClass(element, 'animate-spin')
    }, { once: true })
  }
}