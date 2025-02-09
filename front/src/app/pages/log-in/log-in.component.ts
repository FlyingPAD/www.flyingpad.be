import { Component, HostListener, inject, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from '../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthenticationService } from '../../services/authentication.service';
import { UserService } from '../../services/user.service';
import { ImageUrlService } from '../../services/image-url.service';
import { LanguageService } from '../../services/language.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrl: './log-in.component.scss'
})
export class LogInComponent implements OnInit {
  #flowService = inject(FlowService)
  #authService = inject(AuthenticationService)
  #userService = inject(UserService)
  #formBuilder = inject(FormBuilder)
  #languageService = inject(LanguageService)
  #imageUrlService = inject(ImageUrlService)
  #route = inject(ActivatedRoute)
  #router = inject(Router)

  public flow = this.#flowService.flow
  public user = this.#userService.user
  public environment: string = environment.apiBaseUrl
  public currentLanguage = this.#languageService.currentLanguage
  public closeButtonIsOn: boolean = false
  public isLanguageMenuON: boolean = false
  public formGroup: FormGroup = this.#formBuilder
    .group({
      email: ['', [Validators.required, Validators.email, Validators.maxLength(384)]],
      password: ['', [Validators.required, Validators.minLength(8)]]
    })

  ngOnInit(): void {
    setTimeout(() => {
      this.closeButtonIsOn = true
    }, 500)
  }

  public onLogin(): void {
    if (this.formGroup.valid) {
      this.#authService.login(this.formGroup.value).subscribe({
        next: () => {
          const redirectUrl = this.#route.snapshot.queryParamMap.get('redirectUrl') || '/dashboard'
          this.#router.navigateByUrl(redirectUrl)
        },
        error: (err) => {
          this.#router.navigateByUrl('log-in/error')
        }
      })
    }
  }

  public languageMenuToggle(): void {
    this.isLanguageMenuON = !this.isLanguageMenuON
  }

  public getImageURL(theme: boolean, folderName: string, imageName: string, imageExtension: string): string {
    if (theme) {
      return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
    }
    else {
      return this.#imageUrlService.getImageURLNoTheme(folderName, imageName, imageExtension)
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.onLogin()
        break
    }
  }
}