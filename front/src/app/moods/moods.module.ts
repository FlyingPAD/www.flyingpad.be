import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MoodsRoutingModule } from './moods-routing.module';
import { MoodsGalleryComponent } from './components/moods-gallery/moods-gallery.component';
import { SharedModule } from '../shared/shared.module';
import { MoodDetailsComponent } from './components/mood-details/mood-details.component';
import { MoodEditionComponent } from './components/mood-edition/mood-edition.component';

@NgModule({
  declarations: 
  [
    MoodsGalleryComponent,
    MoodDetailsComponent,
    MoodEditionComponent
  ],
  imports: 
  [
    CommonModule,
    MoodsRoutingModule,
    SharedModule
  ]
})
export class MoodsModule { }