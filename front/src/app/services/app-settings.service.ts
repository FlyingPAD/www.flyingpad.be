import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppSettingsService 
{
  // Window Width
  appScreenWidth : number = window.innerWidth  

  // Window Height        
  appScreenHeight : number = window.innerHeight  

  // Display Mode    
  appDisplayMode : string = this.detectDisplayMode()             
  
  // Detect Display Mode
  detectDisplayMode() : string
  {
    let isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)
    return isMobile ? "Mobile" : "Desktop"
  }
}