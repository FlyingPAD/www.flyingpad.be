import { Component, inject } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MenuMainService } from '../../services/menu-main.service';
import { CommonModule } from '@angular/common';
import { ButtonLoginComponent } from '../button-login/button-login.component';

@Component({
  selector: 'app-menu-main-full',
  standalone: true,
  imports: [RouterModule, CommonModule, ButtonLoginComponent],
  templateUrl: './menu-main-full.component.html',
  styleUrl: './menu-main-full.component.scss'
})
export class MenuMainFullComponent 
{
  menuService = inject(MenuMainService)

  currentYear : number = new Date().getFullYear()

  menuTrigger()
  {
    this.menuService.triggerMenuCustom()
  }
}
