import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuStandardService 
{
  menuOutFull : boolean = false
  page : string = ''

  triggerMenu()
  {
    this.menuOutFull = !this.menuOutFull
  }
}
