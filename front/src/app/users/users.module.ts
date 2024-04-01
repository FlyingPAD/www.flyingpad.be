import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UsersRoutingModule } from './users-routing.module';
import { UserDetailsComponent } from './components/user-details/user-details.component';
import { UserUpdateComponent } from './components/user-update/user-update.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: 
  [
    UserDetailsComponent,
    UserUpdateComponent
  ],
  imports: 
  [
    CommonModule,
    UsersRoutingModule,
    SharedModule
  ]
})
export class UsersModule { }
