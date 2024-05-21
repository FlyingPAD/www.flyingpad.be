import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TagsRoutingModule } from './tags-routing.module';

import { SharedModule } from '../shared/shared.module';

import { TagsGalleryComponent } from './components/tags-gallery/tags-gallery.component';
import { ListComponent } from './components/list/list.component';


@NgModule({
  declarations: 
  [
    TagsGalleryComponent,
    ListComponent,
  ],
  imports: 
  [
    CommonModule,
    TagsRoutingModule,
    SharedModule
  ]
})
export class TagsModule { }
