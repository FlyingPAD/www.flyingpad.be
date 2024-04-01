import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LinksRoutingModule } from './links-routing.module';
import { ListComponent } from './components/list/list.component';
import { SharedModule } from '../shared/shared.module';
import { GalleryComponent } from './components/gallery/gallery.component';


@NgModule({
  declarations: 
  [
    ListComponent,
    GalleryComponent
  ],
  imports: 
  [
    CommonModule,
    LinksRoutingModule,
    SharedModule
  ]
})
export class LinksModule { }
