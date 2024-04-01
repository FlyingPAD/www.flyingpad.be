import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { UserLoginComponent } from './components/user-login/user-login.component';
import { UserRegisterComponent } from './components/user-register/user-register.component';
import { UserLoginErrorComponent } from './components/user-login-error/user-login-error.component';

const routes: Routes = 
[
  { path : 'login', component : UserLoginComponent, title : 'Flying PAD | Login' },
  { path : 'login-error', component : UserLoginErrorComponent, title : 'Flying PAD | Login Error' },
  
  { path : 'register', component : UserRegisterComponent, title : 'Flying PAD | Register' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthenticationRoutingModule { }
