import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoodsGalleryComponent } from './components/moods-gallery/moods-gallery.component';
import { MoodDetailsComponent } from './components/mood-details/mood-details.component';
import { MoodEditionComponent } from './components/mood-edition/mood-edition.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'gallery'},
  { path : 'gallery', component : MoodsGalleryComponent, title : 'Flying PAD | Moods Gallery' },  
  { path : 'mood-details', component : MoodDetailsComponent, title : 'Flying PAD | Mood Details' },
  { path : 'mood-edition', component : MoodEditionComponent, title : 'Flying PAD | Mood Edition' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MoodsRoutingModule { }