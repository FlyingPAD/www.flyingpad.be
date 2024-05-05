import { Component, inject } from '@angular/core';
import { UserService } from '../../../core/services/user.service';

@Component({
  selector: 'app-dashboard-home',
  templateUrl: './dashboard-home.component.html',
  styleUrls: ['./dashboard-home.component.scss']
})
export class DashboardHomeComponent 
{
  userService = inject(UserService)
}
