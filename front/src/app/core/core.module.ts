import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { SharedModule } from '../shared/shared.module';
import { LayoutCustomComponent } from './layouts/layout-custom/layout-custom.component';
import { VideoTestComponent } from './components/video-test/video-test.component';

@NgModule({
  declarations: 
  [
    HomeComponent,
    AboutComponent,
    NotFoundComponent,
    LayoutEmptyComponent,
    LayoutCustomComponent,
    VideoTestComponent,
  ],
  imports: 
  [
    CommonModule,
    SharedModule
  ]
})
export class CoreModule { }