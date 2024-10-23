import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuCustomService 
{
  menuCustomOn : boolean = false
  
  triggerMenuCustom(): void {
    this.menuCustomOn = !this.menuCustomOn
  }

  MenuCustomOn(): void {
    this.menuCustomOn = true
  }

  MenuCustomOff(): void {
    this.menuCustomOn = false
  }
}