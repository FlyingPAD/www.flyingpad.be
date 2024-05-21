import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FranchiseGalleryComponent } from './components/franchise-gallery/franchise-gallery.component';
import { GalleryComponent } from './components/gallery/gallery.component';
import { MediaGalleryComponent } from './components/media-gallery/media-gallery.component';
import { ListComponent } from './components/list/list.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'franchise-gallery'},
  { path : 'franchise-gallery', component : FranchiseGalleryComponent, title : 'Flying PAD | Franchise Gallery' },
  { path : 'gallery', component : GalleryComponent, title : 'Flying PAD | Franchises Gallery' },
  { path : 'media-gallery', component : MediaGalleryComponent, title : 'Flying PAD | Media Gallery' },
  { path : 'list', component : ListComponent, title : 'Flying PAD | Franchises CRUD' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FranchisesRoutingModule { }
