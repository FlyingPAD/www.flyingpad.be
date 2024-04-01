import { Component, inject } from '@angular/core';
import { UserService } from '../../../core/services/client/client-user.service';


@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.scss']
})
export class UserDetailsComponent
{
  userService = inject(UserService)
}