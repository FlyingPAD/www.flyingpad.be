import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardHomeComponent } from './components/dashboard-home/dashboard-home.component';
import { SharedModule } from '../shared/shared.module';
import { LayoutDashboardComponent } from './layouts/layout-dashboard/layout-dashboard.component';


@NgModule({
  declarations: 
  [
    DashboardHomeComponent,
    LayoutDashboardComponent
  ],
  imports: 
  [
    CommonModule,
    DashboardRoutingModule,
    SharedModule
  ]
})
export class DashboardModule { }
