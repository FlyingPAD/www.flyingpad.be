import { Component, inject } from '@angular/core';
import { UserService } from '../../services/http/user.service';

@Component({
  selector: 'app-user-profile-public',
  templateUrl: './user-profile-public.component.html',
  styleUrl: './user-profile-public.component.scss'
})
export class UserProfilePublicComponent {
  #userService = inject(UserService)

  public user = this.#userService.publicUser
}