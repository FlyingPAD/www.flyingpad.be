import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LinksRoutingModule } from './links-routing.module';
import { SharedModule } from '../shared/shared.module';
import { GalleryComponent } from './components/gallery/gallery.component';


@NgModule({
  declarations: 
  [
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
