import { inject, Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class RedirectionService {
  #router = inject(Router)

  public redirect(role: number): void {
    if(role === 1 || role === 2) {
      this.#router.navigateByUrl('/dashboard')
    }
    else this.#router.navigateByUrl('/home')
  }  
}