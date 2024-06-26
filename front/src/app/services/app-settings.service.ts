import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppSettingsService 
{
  appScreenWidth : number = window.innerWidth     
  appScreenHeight : number = window.innerHeight  

  appDisplayMode : string = this.detectDisplayMode()       
  detectDisplayMode() : string
  {
    let isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)
    return isMobile ? "Mobile" : "Desktop"
  }
}