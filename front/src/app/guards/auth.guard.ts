import { CanActivateFn, Router } from '@angular/router';
import { inject } from '@angular/core';
import { TokenService } from '../services/token.service';

export const authGuard: CanActivateFn = (route, state) => {
  const tokenService = inject(TokenService)
  const router = inject(Router)
  
  const token = tokenService.retrieveToken()
  
  if (token) {
    const role = tokenService.getUserRoleFromToken(token)

    if (role === 1 || role === 2) {
      return true
    }
  }
  
  return router.createUrlTree(['/log-in'], { queryParams: { redirectUrl: state.url } })
}