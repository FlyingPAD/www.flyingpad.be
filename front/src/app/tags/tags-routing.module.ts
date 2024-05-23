import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TagsGalleryComponent } from './components/tags-gallery/tags-gallery.component';
import { EditionComponent } from './components/edition/edition.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'gallery'},
  { path : 'gallery', component : TagsGalleryComponent, title : 'Flying PAD | Tags Gallery' },  
  { path : 'edition', component : EditionComponent, title : 'Flying PAD | Tags CRUD' },  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TagsRoutingModule { }
