import { Component, HostListener, inject, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthenticationService } from '../../services/http/authentication.service';
import { ImageUrlService } from '../../services/user-interface/image-url.service';
import { LanguageService } from '../../services/user-interface/language.service';
import { ActivatedRoute, Router } from '@angular/router';
import { MoodService } from '../../services/http/mood.service';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrl: './log-in.component.scss'
})
export class LogInComponent implements OnInit {
  #moodService = inject(MoodService)
  #authService = inject(AuthenticationService)
  #formBuilder = inject(FormBuilder)
  #languageService = inject(LanguageService)
  #imageUrlService = inject(ImageUrlService)
  #route = inject(ActivatedRoute)
  #router = inject(Router)

  public moodsFlow = this.#moodService.moodsFlow
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