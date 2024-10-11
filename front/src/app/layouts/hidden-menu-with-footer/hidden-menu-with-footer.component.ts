import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from '../../models/user';
import { AuthenticationService } from '../../services/authentication.service';
import { MenuCustomService } from '../../services/menu-custom.service';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-hidden-menu-with-footer',
  templateUrl: './hidden-menu-with-footer.component.html',
  styleUrl: './hidden-menu-with-footer.component.scss'
})
export class HiddenMenuWithFooterComponent {
  authService = inject(AuthenticationService)
  userService = inject(UserService)
  menuCustom = inject(MenuCustomService)
  #formBuilder = inject(FormBuilder)
  #router = inject(Router)

  loginTrigger: boolean = false
  overlayTrigger: boolean = false

  formGroup: FormGroup = this.#formBuilder
    .group({
      email: ['', [Validators.required, Validators.email, Validators.maxLength(384)]],
      password: ['', [Validators.required, Validators.minLength(8)]]
    })

  loginTriggerMethod(): void {
    this.loginTrigger = !this.loginTrigger
    this.overlayTrigger = !this.overlayTrigger
  }

  onLogin(): void {
    if (this.formGroup.valid) {
      this.authService.login(this.formGroup.value).subscribe({
        next: (data) => {
          let user: User = this.userService.setSpecificUser(data.token)
          this.authService.acceptConnection()
          // this.#redirectBasedOnUserRole(user.role)
        },
        error: (error) => {
          this.#router.navigateByUrl('authentication/login-error')
          console.error("Login attempt failed.", error)
        }
      })
    }
    this.loginTrigger = false
    this.overlayTrigger = false
  }

  #redirectBasedOnUserRole(role: number): void {
    switch (role) {
      case 1:
        this.#router.navigateByUrl('/home')
        break;
      case 2:
        this.#router.navigateByUrl('/dashboard')
        break;
      default:
        this.#router.navigateByUrl('/home')
        break;
    }
  }

  logout(): void {
    this.authService.logout()
    this.userService.setDefaultUser()
    this.#router.navigateByUrl('/home')
  }

  menuTrigger(): void {
    this.menuCustom.MenuCustomOff()
  }
}