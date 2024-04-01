import { Component, HostListener, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { MenuScrollService } from '../../../core/services/system/menu-scroll.service';

@Component({
  selector: 'app-menu-left-mobile',
  templateUrl: './menu-left-mobile.component.html',
  styleUrls: ['./menu-left-mobile.component.scss']
})
export class MenuLeftMobileComponent 
{
  // Properties :

  menuMobileService = inject(MenuMobileService)
  menuScrollService = inject(MenuScrollService)

  // Methods :

  @HostListener('window:scroll', [])
  onScroll() 
  {
    this.menuScrollService.menuScroll()
  }
}