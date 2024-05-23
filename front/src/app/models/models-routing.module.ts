import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ModelGalleryComponent } from './components/model-gallery/model-gallery.component';
import { EditionComponent } from './components/edition/edition.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'model-gallery'},
  { path : 'model-gallery', component : ModelGalleryComponent, title : 'Flying PAD | Model Gallery' },
  { path : 'edition', component : EditionComponent, title : 'Flying PAD | Models Edition' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ModelsRoutingModule { }
