import { Component, inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../../services/client/client-auth.service';
import { UserService } from '../../services/client/client-user.service';
import { MenuStandardService } from '../../services/system/menu-standard.service';

@Component({
  selector: 'app-layout-default',
  templateUrl: './layout-default.component.html',
  styleUrl: './layout-default.component.scss'
})
export class LayoutDefaultComponent 
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