import { Component, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';

@Component({
  selector: 'app-layout-dashboard',
  templateUrl: './layout-dashboard.component.html',
  styleUrls: ['./layout-dashboard.component.scss']
})
export class LayoutDashboardComponent 
{
  menuMobileService = inject(MenuMobileService)
}