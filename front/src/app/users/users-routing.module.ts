import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserDetailsComponent } from './components/user-details/user-details.component';
import { UserUpdateComponent } from './components/user-update/user-update.component';

const routes: Routes = 
[
  { path : 'user-details', component : UserDetailsComponent, title : 'Flying PAD | User Details' },
  { path : 'user-update', component : UserUpdateComponent, title : 'Flying PAD | Update User' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UsersRoutingModule { }
