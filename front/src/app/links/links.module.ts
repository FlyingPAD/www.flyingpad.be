import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LinksRoutingModule } from './links-routing.module';
import { SharedModule } from '../shared/shared.module';
import { GalleryComponent } from './components/gallery/gallery.component';
import { EditionComponent } from './components/edition/edition.component';


@NgModule({
  declarations: 
  [
    GalleryComponent,
    EditionComponent
  ],
  imports: 
  [
    CommonModule,
    LinksRoutingModule,
    SharedModule
  ]
})
export class LinksModule { }
