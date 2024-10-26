import { Directive, ElementRef, HostListener, Renderer2, inject } from '@angular/core';

@Directive({
  selector: '[appAnimRandom]'
})
export class AnimRandomDirective {
  #elementRef = inject(ElementRef)
  #renderer = inject(Renderer2)

  @HostListener('click')
  onClick() {
    const element = this.#elementRef.nativeElement

    this.#renderer.addClass(element, 'animate')

    element.addEventListener('animationend', () => {
      this.#renderer.removeClass(element, 'animate')
    }, { once: true })
  }
}