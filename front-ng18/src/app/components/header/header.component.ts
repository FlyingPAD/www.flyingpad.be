import { Component, inject } from '@angular/core';
import { AuthenticationService } from '../../services/authentication.service';
import { MenuMainService } from '../../services/menu-main.service';
import { UserService } from '../../services/user.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent 
{
  menuService = inject(MenuMainService)
  // userService = inject(UserService)
  // authService = inject(AuthenticationService)

  // currentYear : number = new Date().getFullYear()

  menuTrigger()
  {
    this.menuService.triggerMenuCustom()
  }
}
