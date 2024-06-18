import { Component, inject } from '@angular/core';
import { LoginFormComponent } from '../../features/login/login-form/login-form.component';
import { AuthenticationService } from '../../services/authentication.service';
import { UserLoginForm } from '../../models/user';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [LoginFormComponent],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent 
{
  #authService = inject(AuthenticationService)
  #toastr = inject(ToastrService)
  handleLogin( credentials : UserLoginForm) 
  {
    this.#authService.login(credentials).subscribe(response => 
    {
      if (response.success) 
      {
        this.#toastr.success('Login', 'Success !')
      } 
      else 
      {
        this.#toastr.error('Login', 'Invalid Credentials !')
      }
    })
  }
}