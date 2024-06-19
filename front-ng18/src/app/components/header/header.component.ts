import { Component, inject } from '@angular/core';
import { MenuMainService } from '../../services/menu-main.service';
import { UserService } from '../../services/user.service';
import { Router, RouterModule } from '@angular/router';
import { AuthenticationService } from '../../services/authentication.service';
import { ToastrService } from 'ngx-toastr';
import { RouteService } from '../../services/route.service';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent 
{
  menuService = inject(MenuMainService)
  userService = inject(UserService)
  #authService = inject(AuthenticationService)
  #toastr = inject(ToastrService)
  #router = inject(Router)
  #route = inject(RouteService)

  menuTrigger()
  {
    this.menuService.triggerMenuCustom()
  }

  login()
  {
    this.#route.routeBeforeLogin = this.#router.url
  }

  logout()
  {
    this.#authService.logout()
    this.#toastr.success('Logout', 'Success !')
    if (this.#router.url === '/dashboard') 
    {
      this.#router.navigateByUrl('/home')
    } 
  }
}