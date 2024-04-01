import { Component, inject } from '@angular/core';
import { MenuDesktopService } from '../../../core/services/system/menu-desktop.service';

@Component({
  selector: 'app-menu-left-desktop',
  templateUrl: './menu-left-desktop.component.html',
  styleUrls: ['./menu-left-desktop.component.scss']
})
export class MenuLeftDesktopComponent 
{
  menuDesktopService = inject(MenuDesktopService)
}