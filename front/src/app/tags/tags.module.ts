import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TagsRoutingModule } from './tags-routing.module';

import { SharedModule } from '../shared/shared.module';

import { TagsGalleryComponent } from './components/tags-gallery/tags-gallery.component';
import { EditionComponent } from './components/edition/edition.component';


@NgModule({
  declarations: 
  [
    TagsGalleryComponent,
    EditionComponent,
  ],
  imports: 
  [
    CommonModule,
    TagsRoutingModule,
    SharedModule
  ]
})
export class TagsModule { }
