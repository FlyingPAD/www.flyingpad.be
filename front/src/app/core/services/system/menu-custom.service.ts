import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuCustomService 
{
  menuCustomOn : boolean = false

  triggerMenuCustom()
  {
    this.menuCustomOn = !this.menuCustomOn
  }
  MenuCustomOn()
  {
    this.menuCustomOn = true
  }
  MenuCustomOff()
  {
    this.menuCustomOn = false
  }
}