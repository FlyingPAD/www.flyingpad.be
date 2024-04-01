import { Component, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';

@Component({
  selector: 'app-menu-trigger-right-filter',
  templateUrl: './menu-trigger-right-filter.component.html',
  styleUrl: './menu-trigger-right-filter.component.scss'
})
export class MenuTriggerRightFilterComponent 
{
  menuService = inject(MenuMobileService)
}