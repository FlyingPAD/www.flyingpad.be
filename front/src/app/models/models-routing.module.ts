import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ModelGalleryComponent } from './components/model-gallery/model-gallery.component';
import { ListComponent } from './components/list/list.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'model-gallery'},
  { path : 'model-gallery', component : ModelGalleryComponent, title : 'Flying PAD | Model Gallery' },
  { path : 'list', component : ListComponent, title : 'Flying PAD | Models CRUD' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ModelsRoutingModule { }
