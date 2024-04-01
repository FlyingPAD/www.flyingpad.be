import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TagsRoutingModule } from './tags-routing.module';

import { SharedModule } from '../shared/shared.module';

import { TagsGalleryComponent } from './components/tags-gallery/tags-gallery.component';
import { TagsWallComponent } from './components/tags-wall/tags-wall.component';


@NgModule({
  declarations: 
  [
    TagsGalleryComponent,
    TagsWallComponent
  ],
  imports: 
  [
    CommonModule,
    TagsRoutingModule,
    SharedModule
  ]
})
export class TagsModule { }
