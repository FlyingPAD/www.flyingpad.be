import { Component, HostListener, inject } from '@angular/core';
import { HeaderService } from '../../services/system/header.service';
import { AuthService } from '../../services/client/client-auth.service';
import { UserService } from '../../services/client/client-user.service';
import { MenuScrollService } from '../../services/system/menu-scroll.service';

@Component({
  selector: 'app-layout-core',
  templateUrl: './layout-core.component.html',
  styleUrl: './layout-core.component.scss'
})
export class LayoutCoreComponent 
{
  headerService = inject(HeaderService)
  menuScrollService = inject(MenuScrollService)
  authService = inject(AuthService)
  userService = inject(UserService)

  // Properties :

  currentYear = new Date().getFullYear()

  // Methods :

  logout() : void 
  {
    this.authService.logout()
    this.userService.setDefaultUser()
  }

  @HostListener('window:scroll', ['$event'])
  onWindowScroll() 
  {
    this.menuScrollService.menuScroll();
  }
}