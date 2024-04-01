import { Component, OnInit, inject } from '@angular/core';
import { AuthService } from '../../services/client/client-auth.service';
import { UserService } from '../../services/client/client-user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent implements OnInit
{
  authService = inject(AuthService)
  userService = inject(UserService)
  #router = inject(Router)

  ngOnInit() : void 
  {
    if(this.userService.appUser.role === 2)
    {
      this.#router.navigateByUrl('dashboard')
    }
  }
}