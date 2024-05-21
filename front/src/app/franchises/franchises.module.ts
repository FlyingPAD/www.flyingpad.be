import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';
import { FranchiseGalleryComponent } from './components/franchise-gallery/franchise-gallery.component';
import { FranchisesRoutingModule } from './franchises-routing.module';
import { GalleryComponent } from './components/gallery/gallery.component';
import { MediaGalleryComponent } from './components/media-gallery/media-gallery.component';
import { ListComponent } from './components/list/list.component';

@NgModule({
  declarations: 
  [
    FranchiseGalleryComponent,
    GalleryComponent,
    MediaGalleryComponent,
    ListComponent
  ],
  imports: 
  [
    CommonModule,
    FranchisesRoutingModule,
    SharedModule
  ]
})
export class FranchisesModule { }
