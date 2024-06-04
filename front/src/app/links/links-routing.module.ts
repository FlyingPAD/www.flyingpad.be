import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GalleryComponent } from './components/gallery/gallery.component';
import { EditionComponent } from './components/edition/edition.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'gallery'},
  
  { path : 'gallery', component : GalleryComponent, title : 'Flying PAD | Links Gallery' },
  { path : 'edition', component : EditionComponent, title : 'Flying PAD | Links Edition' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LinksRoutingModule { }