import { Component, inject, OnDestroy, signal } from '@angular/core';
import { AuthenticationService } from '../../../services/http/authentication.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-email-verification',
  templateUrl: './email-verification.component.html',
  styleUrls: ['./email-verification.component.scss']
})
export class EmailVerificationComponent implements OnDestroy {
  #authenticationService = inject(AuthenticationService)

  #destroy$ = new Subject<void>()

  public isLoading = signal(false)
  public infoMessage = signal<string | null>(null)
  public errorMessage = signal<string | null>(null)


  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }


  public sendVerificationLink(): void {
    this.isLoading.set(true)
    this.infoMessage.set(null)
    this.errorMessage.set(null)

    this.#authenticationService.sendVerificationEmail()
    .pipe(takeUntil(this.#destroy$))
    .subscribe({
      next: response => {
        this.isLoading.set(false)

        if (response.success) this.infoMessage.set('✔ Un email de vérification vous a bien été envoyé.')
        else this.errorMessage.set(response.message)
      },
      error: () => {
        this.isLoading.set(false)
        this.errorMessage.set('❌ Impossible d’envoyer l’email. Réessayez plus tard.')
      }
    })
  }
}