import { Component, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';

@Component({
  selector: 'app-menu-trigger-right',
  templateUrl: './menu-trigger-right.component.html',
  styleUrls: ['./menu-trigger-right.component.scss']
})
export class MenuTriggerRightComponent 
{
  menuService = inject(MenuMobileService)
}
