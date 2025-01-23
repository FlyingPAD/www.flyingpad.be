import { Component, Input } from '@angular/core';
import { User } from '../../../interfaces/user';

@Component({
  selector: 'app-dashboard-header',
  templateUrl: './dashboard-header.component.html',
  styleUrl: './dashboard-header.component.scss'
})
export class DashboardHeaderComponent {
  @Input() user!: User
}