import { Component, inject } from '@angular/core';
import { AppSettingsService } from '../../services/app-settings.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent 
{
  appSettings = inject(AppSettingsService)
}
