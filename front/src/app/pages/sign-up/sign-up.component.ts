// src/app/pages/sign-up/sign-up.component.ts
import { Component, HostListener, OnDestroy, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators, AbstractControlOptions } from '@angular/forms';
import { Router } from '@angular/router';
import { ReCaptchaV3Service } from 'ng-recaptcha';
import { AuthenticationService } from '../../services/http/authentication.service';
import { ImageUrlService } from '../../services/user-interface/image-url.service';
import { LanguageService } from '../../services/user-interface/language.service';
import { MoodService } from '../../services/http/mood.service';
import { environment } from '../../../environments/environment';
import { Subject, takeUntil } from 'rxjs';
import { CaptchaType, RegisterCommandResponse } from '../../interfaces/authentication';
import { CustomError } from '../../interfaces/error';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.scss']
})
export class SignUpComponent implements OnInit, OnDestroy {
  #fb            = inject(FormBuilder);
  #auth          = inject(AuthenticationService);
  #router        = inject(Router);
  #recaptchaV3   = inject(ReCaptchaV3Service);
  #moodService   = inject(MoodService);
  #langService   = inject(LanguageService);
  #imgService    = inject(ImageUrlService);
  #destroy$      = new Subject<void>();

  public closeButtonIsOn    = false;
  public isLanguageMenuON   = false;
  public moodsFlow          = this.#moodService.moodsFlow;
  public currentLanguage    = this.#langService.currentLanguage;
  public environment        = environment.apiBaseUrl;
  public recaptchaSiteKeyV2 = environment.recaptchaSiteKeyV2;

  public useV2   = false;
  public v2Error = false;

  public formGroup: FormGroup = this.#fb.group({
    userName:    ['', [Validators.required, Validators.maxLength(50)]],
    firstName:   ['', [Validators.required, Validators.maxLength(50)]],
    lastName:    ['', [Validators.required, Validators.maxLength(50)]],
    birthdate:   ['', [Validators.required]],
    email:       ['', [Validators.required, Validators.email, Validators.maxLength(384)]],
    pass:        ['', [Validators.required, Validators.minLength(8)]],
    confirmPass: ['', [Validators.required]]
  } as { [key: string]: any }, <AbstractControlOptions>{
    validator: this.passwordMatchValidator
  });

  ngOnInit(): void {
    setTimeout(() => this.closeButtonIsOn = true, 500);
  }

  ngOnDestroy(): void {
    this.#destroy$.next();
    this.#destroy$.complete();
  }

  private passwordMatchValidator(fg: FormGroup): { [key: string]: boolean } | null {
    return fg.get('pass')!.value === fg.get('confirmPass')!.value
      ? null
      : { passwordMismatch: true };
  }

  public onSubmit(): void {
    if (this.formGroup.invalid) return;
    this.v2Error = false;

    if (!this.useV2) {
      this.#recaptchaV3.execute('register')
        .pipe(takeUntil(this.#destroy$))
        .subscribe({
          next: token => this.callRegister(token, 'v3'),
          error: err   => {
            console.log('[SignUp] reCAPTCHA v3 execution error', err);
            this.v2Error = true;
          }
        });
    }
    // si useV2 === true, on attend onV2Resolved()
  }

  private callRegister(token: string|null, type: CaptchaType): void {
    console.log(`[SignUp] callRegister type=${type}, token=`, token);
    if (!token) {
      this.v2Error = true;
      return;
    }
    this.v2Error = false;

    const f = this.formGroup.value;
    const payload = {
      userName:    f.userName,
      firstName:   f.firstName,
      lastName:    f.lastName,
      birthdate:   f.birthdate,
      email:       f.email,
      pass:        f.pass,
      confirmPass: f.confirmPass,
      captchaToken: token,
      captchaType:  type
    };

    this.#auth.register(payload)
      .pipe(takeUntil(this.#destroy$))
      .subscribe({
        next: (res: RegisterCommandResponse & { needV2?: boolean }) => {
          console.log('[SignUp] register response', res);
          if (res.success) {
            // inscription OK
            this.#router.navigateByUrl('/dashboard');
          } else if (res.needV2) {
            // fallback vers v2
            console.log('[SignUp] fallback to v2');
            this.useV2 = true;
          } else {
            // autre échec (email, validation…)
            this.v2Error = true;
          }
        },
        error: (err: CustomError) => {
          console.log('[SignUp] HTTP error', err);
          this.v2Error = true;
        }
      });
  }

  public onV2Resolved(token: string|null): void {
    console.log('[SignUp] onV2Resolved token=', token);
    this.callRegister(token, 'v2');
  }

  @HostListener('window:keydown', ['$event'])
  public onKeyPress(event: KeyboardEvent): void {
    if (event.key === 'Enter') this.onSubmit();
  }

  public languageMenuToggle(): void {
    this.isLanguageMenuON = !this.isLanguageMenuON;
  }

  public getImageURL(theme: boolean, folder: string, name: string, ext: string): string {
    return theme
      ? this.#imgService.getImageURL(folder, name, ext)
      : this.#imgService.getImageURLNoTheme(folder, name, ext);
  }
}