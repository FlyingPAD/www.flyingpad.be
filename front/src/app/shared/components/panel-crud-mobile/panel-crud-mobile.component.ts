import { Component, inject } from '@angular/core';
import { MenuMobileService } from '../../../core/services/menu-mobile.service';

@Component({
  selector: 'app-panel-crud-mobile',
  templateUrl: './panel-crud-mobile.component.html',
  styleUrl: './panel-crud-mobile.component.scss'
})
export class PanelCrudMobileComponent 
{
  menuService = inject(MenuMobileService)
}
