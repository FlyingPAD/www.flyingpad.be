import { Component, inject } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { UserService } from '../../services/user.service';
import { MenuCustomService } from '../../services/menu-custom.service';

@Component({
  selector: 'app-layout-custom',
  templateUrl: './layout-custom.component.html',
  styleUrl: './layout-custom.component.scss'
})
export class LayoutCustomComponent 
{
  authService = inject(AuthService)
  userService = inject(UserService)
  menuCustom = inject(MenuCustomService)
  currentYear = new Date().getFullYear()
  
  logout() : void 
  {
    this.authService.logout()
    this.userService.setDefaultUser()
  }

  menuTrigger() : void
  {
    this.menuCustom.MenuCustomOff()
  }
}