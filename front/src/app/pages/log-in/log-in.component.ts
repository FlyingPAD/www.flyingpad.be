import { Component, inject, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from '../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from '../../interfaces/user';
import { AuthenticationService } from '../../services/authentication.service';
import { UserService } from '../../services/user.service';
import { ImageUrlService } from '../../services/display/image-url.service';
import { LanguageService } from '../../services/display/language.service';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrl: './log-in.component.scss'
})
export class LogInComponent implements OnInit {
  #flowService = inject(FlowService)
  authService = inject(AuthenticationService)
  userService = inject(UserService)
  #formBuilder = inject(FormBuilder)
  #router = inject(Router)
  #languageService = inject(LanguageService)
  #imageUrlService = inject(ImageUrlService)
  flow = this.#flowService.flow
  environment: string = environment.apiBaseUrl
  currentLanguage = this.#languageService.currentLanguage

  public closeButtonIsOn: boolean = false

  formGroup: FormGroup = this.#formBuilder
    .group({
      email: ['', [Validators.required, Validators.email, Validators.maxLength(384)]],
      password: ['', [Validators.required, Validators.minLength(8)]]
    })

  ngOnInit(): void {
    setTimeout( () => {
      this.closeButtonIsOn = true
    }, 500)
  }

  onLogin(): void {
    if (this.formGroup.valid) {
      this.authService.login(this.formGroup.value).subscribe({
        next: (data) => {
          let user: User = this.userService.setSpecificUser(data.token)
          this.authService.acceptConnection()
          this.#redirectBasedOnUserRole(user.role)
        },
        error: (error) => {
          this.#router.navigateByUrl('authentication/login-error')
          console.error("Login attempt failed.", error)
        }
      })
    }
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

  isLanguageMenuON : boolean = false

  languageMenuToggle(): void {
    this.isLanguageMenuON = !this.isLanguageMenuON
  }

  public getImageURL(theme: boolean, folderName: string, imageName: string, imageExtension: string): string {
    if(theme) {
      return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
    }
    else {
      return this.#imageUrlService.getImageURLNoTheme(folderName, imageName, imageExtension)
    }
  }
}