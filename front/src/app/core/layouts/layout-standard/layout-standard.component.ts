import { Component, inject } from '@angular/core';
import { UserService } from '../../services/client/client-user.service';
import { AuthService } from '../../services/client/client-auth.service';
import { ActivatedRoute, Router } from '@angular/router';
import { MenuStandardService } from '../../services/system/menu-standard.service';


@Component({
  selector: 'app-layout-standard',
  templateUrl: './layout-standard.component.html',
  styleUrl: './layout-standard.component.scss'
})
export class LayoutStandardComponent 
{
  userService = inject(UserService)
  authService = inject(AuthService)
  route = inject(ActivatedRoute)
  router = inject(Router)

  menuStandard = inject(MenuStandardService)

  logout() : void 
  {
    this.authService.logout()
    this.userService.setDefaultUser()
  }

  goTo(page : string)
  {
    this.router.navigateByUrl(page)
  }
}