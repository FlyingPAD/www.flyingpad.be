import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuScrollService 
{
  // Properties :

  windowHeight : number = 0
  windowWidth : number = 0
  
  pageHeight : number = 0
  pageWidth : number = 0

  menuHeight : number = 0
  menuHalf : number = 0           // If menu > window
  
  topPosition : number = 15

  // Methods :

  menuScroll() : void
  {
    this.windowHeight = window.innerHeight
    this.windowWidth = window.innerWidth

    this.pageHeight = document.body.scrollHeight
    this.pageWidth = document.body.scrollWidth

    this.menuHeight = document.querySelector('#header_mobile')?.clientHeight || 0
    this.menuHalf = this.menuHeight - this.windowHeight

    // When scrolling Up :

    if(window.scrollY < this.topPosition - 75) 
    {
      if(window.scrollY <= 0 || window.scrollY < 50)
      {
        this.topPosition = 15
      }
      else this.topPosition = window.scrollY + 15
    }

    // When scrolling Down :

    if(this.menuHalf <= 0) // If Menu < Window
    {
      if(window.scrollY > this.topPosition + 150) // When Scrolling Down : 
      {
        if(window.scrollY > this.pageHeight - this.menuHeight )
        {
          this.topPosition = this.pageHeight - this.menuHeight - 15
        }
        else this.topPosition = window.scrollY + 15
      }
    }

    if(this.menuHalf > 0) // If Menu > Window
    { 
      if(window.scrollY > this.topPosition + this.menuHalf + 150) // When Scrolling Down : 
      {
        if(window.scrollY > this.pageHeight - this.menuHeight )
        {
          this.topPosition = this.pageHeight - this.menuHeight - 15
        }
        else this.topPosition = window.scrollY + 15
      }
    }

    // console.log('-----------------------------------------')
    // console.log(' - Window Height : ' + this.windowHeight)
    // console.log(' - Window Width : ' + this.windowWidth)
    // console.log('---')
    // console.log(' - Page Height : ' + this.pageHeight)
    // console.log(' - Page Width : ' + this.pageWidth)
    // console.log('---')
    // console.log(' - Menu Height : ' + this.menuHeight)
    // console.log(' - Menu Half : ' + this.menuHalf)
    // console.log('---')
    // console.log(' - Current Scroll Position : ' + window.scrollY)
    // console.log(' - Menu Top Position : ' + this.topPosition)
  }
}