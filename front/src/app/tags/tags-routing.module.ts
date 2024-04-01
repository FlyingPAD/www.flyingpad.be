import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TagsGalleryComponent } from './components/tags-gallery/tags-gallery.component';
import { TagsWallComponent } from './components/tags-wall/tags-wall.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'gallery'},
  { path : 'gallery', component : TagsGalleryComponent, title : 'Flying PAD | Tags Gallery' },  
  { path : 'wall', component : TagsWallComponent, title : 'Flying PAD | Wall of Tags' }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TagsRoutingModule { }
