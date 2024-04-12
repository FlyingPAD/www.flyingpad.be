import { Injectable, RendererFactory2, inject } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuCustomService 
{
  #renderer = inject(RendererFactory2).createRenderer(null, null)
  
  #lastScrollTop: number = 0

  menuCustomOn: boolean = false
  
  triggerMenuCustom() : void
  {
    if (!this.menuCustomOn) 
    {
      this.#lastScrollTop = window.scrollY
      this.#renderer.setStyle(document.body, 'top', `-${this.#lastScrollTop}px`)
      this.#renderer.addClass(document.body, 'fixed-body')
    } 
    else 
    {
      this.#renderer.removeClass(document.body, 'fixed-body')
      this.#renderer.removeStyle(document.body, 'top')
      window.scrollTo(0, this.#lastScrollTop)
    }
    this.menuCustomOn = !this.menuCustomOn
  }

  MenuCustomOn() : void 
  {
    this.#lastScrollTop = window.scrollY
    this.#renderer.setStyle(document.body, 'top', `-${this.#lastScrollTop}px`)
    this.#renderer.addClass(document.body, 'fixed-body')
    this.menuCustomOn = true
  }

  MenuCustomOff() : void 
  {
    this.#renderer.removeClass(document.body, 'fixed-body')
    this.#renderer.removeStyle(document.body, 'top')
    window.scrollTo(0, this.#lastScrollTop)
    this.menuCustomOn = false
  }
}