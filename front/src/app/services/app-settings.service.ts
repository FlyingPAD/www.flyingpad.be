import { Injectable } from '@angular/core';
import screenfull from 'screenfull';

@Injectable({
  providedIn: 'root'
})
export class AppSettingsService {
  appScreenWidth : number = window.innerWidth     
  appScreenHeight : number = window.innerHeight  
  appDisplayMode : string = this.detectDisplayMode()     
  isFullscreen: boolean = false
    
  detectDisplayMode(): string {
    let isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)
    return isMobile ? "Mobile" : "Desktop"
  }

  updateDisplaySettings(): void {
    this.appScreenWidth = screenfull.isFullscreen ? window.screen.width : window.innerWidth
    this.appScreenHeight = screenfull.isFullscreen ? window.screen.height : window.innerHeight
  }

  toggleFullscreen(): void {
    if (screenfull.isEnabled) {
      screenfull.toggle().then(() => {
        this.updateDisplaySettings()
        this.isFullscreen = !this.isFullscreen
      })
    }
  }
}