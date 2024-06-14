import { Component, inject } from '@angular/core';
import { UserService } from '../../../services/user.service';
import { AuthService } from '../../../services/auth.service';
import { AppSettingsService } from '../../../services/app-settings.service';

@Component({
  selector: 'app-dashboard-home',
  templateUrl: './dashboard-home.component.html',
  styleUrls: ['./dashboard-home.component.scss']
})
export class DashboardHomeComponent 
{
  userService = inject(UserService)
  authService = inject(AuthService)
  appSettings = inject(AppSettingsService)
}
