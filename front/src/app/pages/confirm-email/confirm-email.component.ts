import { Component, inject, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from '../../services/http/authentication.service';
import { TokenService } from '../../services/token.service';
import { UserService } from '../../services/http/user.service';

@Component({
  selector: 'app-confirm-email',
  templateUrl: './confirm-email.component.html',
  styleUrls: ['./confirm-email.component.scss']
})
export class ConfirmEmailComponent implements OnInit, OnDestroy {
  #authService = inject(AuthenticationService);
  #userService = inject(UserService);
  #tokenService = inject(TokenService);
  #route = inject(ActivatedRoute);
  #router = inject(Router);

  public status: 'pending' | 'success' | 'error' = 'pending';
  public countdown = 15;
  private countdownInterval?: number;

  ngOnInit(): void {
    const token = this.#route.snapshot.paramMap.get('token') ?? '';
    if (!token) {
      this.status = 'error';
      return;
    }

    this.#authService.confirmEmail(token).subscribe({
      next: response => {
        if (response.success) {
          // Met à jour le profil en mémoire
          const jwt = this.#tokenService.retrieveToken();
          if (jwt) {
            const id = this.#tokenService.getUserIdFromToken(jwt);
            const role = this.#tokenService.getUserRoleFromToken(jwt);
            this.#userService.getUser(id, role).subscribe({
              next: () => this.handleSuccess(),
              error: () => this.handleSuccess()
            });
          } else {
            this.handleSuccess();
          }
        } else {
          this.status = 'error';
        }
      },
      error: () => this.status = 'error'
    });
  }

  private handleSuccess(): void {
    this.status = 'success';
    // Lance le décompte de 15 s
    this.countdownInterval = window.setInterval(() => {
      this.countdown--;
      if (this.countdown <= 0) {
        this.redirectNow();
      }
    }, 1000);
  }

  /** Redirige immédiatement vers le dashboard et stoppe le timer */
  public redirectNow(): void {
    if (this.countdownInterval) {
      clearInterval(this.countdownInterval);
    }
    this.#router.navigate(['/dashboard']);
  }

  ngOnDestroy(): void {
    if (this.countdownInterval) {
      clearInterval(this.countdownInterval);
    }
  }
}