import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TagsRoutingModule } from './tags-routing.module';

import { SharedModule } from '../shared/shared.module';

import { TagsGalleryComponent } from './components/tags-gallery/tags-gallery.component';


@NgModule({
  declarations: 
  [
    TagsGalleryComponent,
  ],
  imports: 
  [
    CommonModule,
    TagsRoutingModule,
    SharedModule
  ]
})
export class TagsModule { }
