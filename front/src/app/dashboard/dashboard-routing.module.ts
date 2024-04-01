import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardHomeComponent } from './components/dashboard-home/dashboard-home.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'home'},
  { path : 'home', component : DashboardHomeComponent, title : 'Flying PAD | Dashboard' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
