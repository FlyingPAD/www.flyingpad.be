import { Component, HostListener, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { MenuScrollService } from '../../../core/services/system/menu-scroll.service';

@Component({
  selector: 'app-menu-right-mobile',
  templateUrl: './menu-right-mobile.component.html',
  styleUrls: ['./menu-right-mobile.component.scss']
})
export class MenuRightMobileComponent 
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