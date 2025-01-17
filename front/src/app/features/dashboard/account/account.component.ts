import { Component, Input } from '@angular/core';
import { User } from '../../../interfaces/user';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrl: './account.component.scss'
})
export class AccountComponent {
  @Input() user! : User
}