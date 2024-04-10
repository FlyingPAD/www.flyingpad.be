import { Component, inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../../services/client/client-auth.service';
import { UserService } from '../../services/client/client-user.service';
import { MenuCustomService } from '../../services/system/menu-custom.service';

@Component({
  selector: 'app-layout-custom',
  templateUrl: './layout-custom.component.html',
  styleUrl: './layout-custom.component.scss'
})
export class LayoutCustomComponent 
{
  userService = inject(UserService)
  authService = inject(AuthService)
  route = inject(ActivatedRoute)
  router = inject(Router)

  menuCustom = inject(MenuCustomService)

  currentYear = new Date().getFullYear()
  
  logout() : void 
  {
    this.authService.logout()
    this.userService.setDefaultUser()
  }

  menuTrigger()
  {
    this.menuCustom.MenuCustomOff()
  }
}