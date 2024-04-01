import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoodsGalleryComponent } from './components/moods-gallery/moods-gallery.component';
import { MoodDetailsComponent } from './components/mood-details/mood-details.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'gallery'},
  { path : 'gallery', component : MoodsGalleryComponent, title : 'Flying PAD | Moods Gallery' },
  { path : 'gallery/:id', component : MoodsGalleryComponent, title : 'Flying PAD | Moods Gallery' },
  
  { path : 'mood-details', component : MoodDetailsComponent, title : 'Flying PAD | Mood Details' },
  { path : 'mood-details/:id', component : MoodDetailsComponent, title : 'Flying PAD | Mood Details' },
  { path : 'mood-details/:galleryMode/:id', component : MoodDetailsComponent, title : 'Flying PAD | Mood Details' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MoodsRoutingModule { }