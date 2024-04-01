import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MoodsRoutingModule } from './moods-routing.module';
import { MoodsGalleryComponent } from './components/moods-gallery/moods-gallery.component';
import { SharedModule } from '../shared/shared.module';
import { MoodDetailsComponent } from './components/mood-details/mood-details.component';


@NgModule({
  declarations: [
    MoodsGalleryComponent,
    MoodDetailsComponent
  ],
  imports: [
    CommonModule,
    MoodsRoutingModule,
    SharedModule
  ]
})
export class MoodsModule { }
