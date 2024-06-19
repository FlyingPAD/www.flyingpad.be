import { Component, inject } from '@angular/core';
import { AppSettingsService } from '../../services/app-settings.service';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent 
{
  appSettings = inject(AppSettingsService)
}
