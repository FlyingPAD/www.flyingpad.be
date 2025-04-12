import { Component, inject, Input } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../../../services/http/user.service';

@Component({
  selector: 'app-bottom-icon-edit',
  templateUrl: './bottom-icon-edit.component.html'
})
export class BottomIconEditComponent {
  #userService = inject(UserService)
  #router = inject(Router)

  public user = this.#userService.user

  @Input() page: string | undefined

  public GoTo(page: string): void {
    this.#router.navigateByUrl(page)
  }
}