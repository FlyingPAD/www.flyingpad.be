import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RightColumnService {
    menuTrigger : boolean = false      // Menu Trigger ON / OFF
    menuLActive : boolean = false      // Panel ON / OFF - Left
    menuRActive : boolean = false      // Panel ON / OFF - Right
    
    scrollToStart(elementId: string) : void 
    {
      const domElement = document.getElementById(elementId)
      if (domElement) 
      {
        domElement.scrollIntoView({ behavior: "smooth", block: "center", inline: "nearest" });
      }
    }
    
    menuON() : void 
    {
      this.menuTrigger = true
    }
  
    menuOFF() : void 
    {
      this.menuTrigger = false
    }
  
    menuLTrigger() : void 
    {
      this.menuLActive = !this.menuLActive
      this.menuRActive = false
    }
    
    menuRTrigger() : void 
    {
      this.menuRActive = !this.menuRActive
      this.menuLActive = false
    }
  
    menuLTriggerFull() : void 
    {
      this.menuLActive = !this.menuLActive
    }
    
    menuRTriggerFull() : void 
    {
      this.menuRActive = !this.menuRActive
    }
  
    allMenuTriggerOn() : void 
    {
      this.menuLActive = true
      this.menuRActive = true
    }
  
    allMenuTriggerOff() : void 
    {
      this.menuLActive = false
      this.menuRActive = false
    }
  }