import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ModelGalleryComponent } from './components/model-gallery/model-gallery.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'model-gallery'},
  { path : 'model-gallery', component : ModelGalleryComponent, title : 'Flying PAD | Model Gallery' },
  { path : 'model-gallery/:id', component : ModelGalleryComponent, title : 'Flying PAD | Model Gallery' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ModelsRoutingModule { }
