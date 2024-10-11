import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-my-account',
  templateUrl: './my-account.component.html',
  styleUrl: './my-account.component.scss'
})
export class MyAccountComponent {
  #router = inject(Router)

  goTo(url : string): void {
    this.#router.navigateByUrl(url)
  }
}