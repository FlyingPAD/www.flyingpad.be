import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';
import { FranchiseGalleryComponent } from './components/franchise-gallery/franchise-gallery.component';
import { FranchisesRoutingModule } from './franchises-routing.module';
import { GalleryComponent } from './components/gallery/gallery.component';

@NgModule({
  declarations: 
  [
    FranchiseGalleryComponent,
    GalleryComponent
  ],
  imports: 
  [
    CommonModule,
    FranchisesRoutingModule,
    SharedModule
  ]
})
export class FranchisesModule { }
