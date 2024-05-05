import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../../../core/services/auth.service';
import { User } from '../../../core/models/user';
import { UserService } from '../../../core/services/user.service';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.scss']
})
export class UserLoginComponent implements OnInit 
{
  // Define formGroup using FormBuilder for login form controls
  
  formGroup: FormGroup = inject(FormBuilder)
  .group({
    email: ['', [Validators.required, Validators.email, Validators.maxLength(384)]],
    password: ['', [Validators.required, Validators.minLength(8)]]
  })

  // Injecting necessary services using inject utility function

  #router = inject(Router)
  #authService = inject(AuthService)
  #userService = inject(UserService)

  ngOnInit() : void 
  {
    window.scrollTo(0, 0)    // Scrolls to the top of the page on component init
  }

  // Method to handle form submission

  onLogin() : void 
  {
    if (this.formGroup.valid) 
    {
      this.#authService.login(this.formGroup.value).subscribe({
        next: (data) => 
        {
          // Store User in Service / Get User from Service

          let user : User = this.#userService.setSpecificUser(data.token)

          // Accept Connection

          this.#authService.acceptConnection()
  
          // Redirect user based on their numeric role

          this.#redirectBasedOnUserRole(user.role)
        },
        error: (error) => 
        {
          this.#router.navigateByUrl('authentication/login-error')
          console.error("Login attempt failed.", error)
        }
      })
    }
  }

  // Private method to redirect user based on their role

  #redirectBasedOnUserRole( role : number ) : void 
  {
    switch (role) 
    {
      case 1:
        this.#router.navigateByUrl('/home')       // Default User role redirects to home
        break;
      case 2:
        this.#router.navigateByUrl('/dashboard')  // Administrator role redirects to dashboard
        break;
      default:
        this.#router.navigateByUrl('/home')       // Redirect back to login on undefined role
        break;
    }
  }
}