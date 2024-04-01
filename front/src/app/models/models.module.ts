import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModelGalleryComponent } from './components/model-gallery/model-gallery.component';
import { SharedModule } from '../shared/shared.module';
import { ModelsRoutingModule } from './models-routing.module';

@NgModule({
  declarations: 
  [
    ModelGalleryComponent
  ],
  imports: 
  [
    CommonModule,
    ModelsRoutingModule,
    SharedModule
  ]
})
export class ModelsModule { }
