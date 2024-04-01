import { Component, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';

@Component({
  selector: 'app-menu-trigger-left',
  templateUrl: './menu-trigger-left.component.html',
  styleUrls: ['./menu-trigger-left.component.scss']
})
export class MenuTriggerLeftComponent 
{
  menuService = inject(MenuMobileService)
}