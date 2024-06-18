import { Component, inject } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MenuMainService } from '../../services/menu-main.service';
import { CommonModule } from '@angular/common';
import { UserService } from '../../services/user.service';
import { AuthenticationService } from '../../services/authentication.service';

@Component({
  selector: 'app-menu-main-full',
  standalone: true,
  imports: [RouterModule, CommonModule],
  templateUrl: './menu-main-full.component.html',
  styleUrl: './menu-main-full.component.scss'
})
export class MenuMainFullComponent 
{
  menuService = inject(MenuMainService)
  // userService = inject(UserService)
  // authService = inject(AuthenticationService)

  currentYear : number = new Date().getFullYear()

  menuTrigger()
  {
    this.menuService.triggerMenuCustom()
  }
}
