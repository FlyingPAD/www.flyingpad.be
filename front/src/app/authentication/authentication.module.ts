import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthenticationRoutingModule } from './authentication-routing.module';

import { UserLoginComponent } from './components/user-login/user-login.component';
import { UserRegisterComponent } from './components/user-register/user-register.component';
import { SharedModule } from '../shared/shared.module';
import { UserLoginErrorComponent } from './components/user-login-error/user-login-error.component';


@NgModule({
  declarations: 
  [
    UserLoginComponent,
    UserRegisterComponent,
    UserLoginErrorComponent,
  ],
  imports: 
  [
    CommonModule,
    AuthenticationRoutingModule,
    SharedModule
  ]
})
export class AuthenticationModule { }
