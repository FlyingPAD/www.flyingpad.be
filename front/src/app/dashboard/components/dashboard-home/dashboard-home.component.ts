import { Component, inject } from '@angular/core';
import { UserService } from '../../../core/services/user.service';
import { AuthService } from '../../../core/services/auth.service';

@Component({
  selector: 'app-dashboard-home',
  templateUrl: './dashboard-home.component.html',
  styleUrls: ['./dashboard-home.component.scss']
})
export class DashboardHomeComponent 
{
  userService = inject(UserService)
  authService = inject(AuthService)

  call()
  {
    this.authService.HangFireDashBoard().subscribe()
    window.open('https://back.flyingpad.be/hangfire', '_blank')
  }
}
