import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { SharedModule } from '../shared/shared.module';
import { LayoutStandardComponent } from './layouts/layout-standard/layout-standard.component';
import { LayoutDefaultComponent } from './layouts/layout-default/layout-default.component';
import { LayoutCustomComponent } from './layouts/layout-custom/layout-custom.component';

@NgModule({
  declarations: 
  [
    HomeComponent,
    AboutComponent,
    NotFoundComponent,
    LayoutEmptyComponent,
    LayoutStandardComponent,
    LayoutDefaultComponent,
    LayoutCustomComponent,
  ],
  imports: 
  [
    CommonModule,
    SharedModule
  ]
})
export class CoreModule { }