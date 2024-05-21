import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TagsGalleryComponent } from './components/tags-gallery/tags-gallery.component';
import { ListComponent } from './components/list/list.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'gallery'},
  { path : 'gallery', component : TagsGalleryComponent, title : 'Flying PAD | Tags Gallery' },  
  { path : 'list', component : ListComponent, title : 'Flying PAD | Tags CRUD' },  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TagsRoutingModule { }
