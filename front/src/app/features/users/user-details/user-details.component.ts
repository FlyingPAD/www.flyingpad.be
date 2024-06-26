import { Component, inject } from '@angular/core';
import { UserService } from '../../../services/user.service';


@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.scss']
})
export class UserDetailsComponent
{
  userService = inject(UserService)
}