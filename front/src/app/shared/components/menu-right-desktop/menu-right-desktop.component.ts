import { Component, inject } from '@angular/core';
import { MenuDesktopService } from '../../../core/services/menu-desktop.service';

@Component({
  selector: 'app-menu-right-desktop',
  templateUrl: './menu-right-desktop.component.html',
  styleUrls: ['./menu-right-desktop.component.scss']
})
export class MenuRightDesktopComponent 
{
  menuDesktopService = inject(MenuDesktopService)
}
