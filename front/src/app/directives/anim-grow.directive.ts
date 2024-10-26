import { Directive, ElementRef, HostListener, Renderer2, inject } from '@angular/core';

@Directive({
  selector: '[appAnimGrow]'
})
export class AnimGrowDirective {
  #elementRef = inject(ElementRef)
  #renderer = inject(Renderer2)

  @HostListener('click')
  onClick() {
    const element = this.#elementRef.nativeElement

    this.#renderer.addClass(element, 'animate-grow')

    element.addEventListener('animationend', () => {
      this.#renderer.removeClass(element, 'animate-grow')
    }, { once: true })
  }
}