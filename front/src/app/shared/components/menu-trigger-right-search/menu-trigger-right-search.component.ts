import { Component, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';

@Component({
  selector: 'app-menu-trigger-right-search',
  templateUrl: './menu-trigger-right-search.component.html',
  styleUrl: './menu-trigger-right-search.component.scss'
})
export class MenuTriggerRightSearchComponent 
{
  menuService = inject(MenuMobileService)
}