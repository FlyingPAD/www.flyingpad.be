import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FranchiseGalleryComponent } from './components/franchise-gallery/franchise-gallery.component';
import { GalleryComponent } from './components/gallery/gallery.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'franchise-gallery'},
  { path : 'franchise-gallery', component : FranchiseGalleryComponent, title : 'Flying PAD | Franchise Gallery' },
  { path : 'franchise-gallery/:id', component : FranchiseGalleryComponent, title : 'Flying PAD | Franchise Gallery' },
  { path : 'gallery', component : GalleryComponent, title : 'Flying PAD | Franchises Gallery' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FranchisesRoutingModule { }
