import { Component, inject } from '@angular/core';
import { LoginFormComponent } from '../../features/login/login-form/login-form.component';
import { AuthenticationService } from '../../services/authentication.service';
import { UserLoginForm } from '../../models/user';
import { ToastrService } from 'ngx-toastr';
import { Router, RouterModule } from '@angular/router';
import { RouteService } from '../../services/route.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [LoginFormComponent, RouterModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent 
{
  #authService = inject(AuthenticationService)
  #toastr = inject(ToastrService)
  #router = inject(Router)
  #route = inject(RouteService)
  handleLogin( credentials : UserLoginForm ) 
  {
    this.#authService.login(credentials).subscribe(response => 
    {
      if (response.success) 
      {
        this.#toastr.success('Login', 'Success !')
        if(this.#route.routeBeforeLogin === '/home' || this.#route.routeBeforeLogin === '/login')
        {
          this.#router.navigateByUrl('/')
        }
        else this.#router.navigateByUrl(this.#route.routeBeforeLogin)
      } 
      else 
      {
        this.#toastr.error('Login', 'Invalid Credentials !')
      }
    })
  }
}