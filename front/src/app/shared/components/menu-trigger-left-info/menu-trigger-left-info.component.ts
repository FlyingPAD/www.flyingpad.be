import { Component, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';

@Component({
  selector: 'app-menu-trigger-left-info',
  templateUrl: './menu-trigger-left-info.component.html',
  styleUrl: './menu-trigger-left-info.component.scss'
})
export class MenuTriggerLeftInfoComponent 
{
  menuService = inject(MenuMobileService)
}