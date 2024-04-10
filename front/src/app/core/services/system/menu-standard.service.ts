import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuStandardService 
{
  menuOutFull : boolean = false
  page : string = ''

  menuDesktopOn : boolean = true

  triggerMenu()
  {
    this.menuOutFull = !this.menuOutFull
  }

  triggerDesktopMenu()
  {
    this.menuDesktopOn = !this.menuDesktopOn
  }
}
