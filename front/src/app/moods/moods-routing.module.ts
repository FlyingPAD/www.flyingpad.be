import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoodsGalleryComponent } from './components/moods-gallery/moods-gallery.component';
import { MoodDetailsComponent } from './components/mood-details/mood-details.component';
import { MoodEditionComponent } from './components/mood-edition/mood-edition.component';
import { CreateMoodImageComponent } from './components/create-mood-image/create-mood-image.component';
import { MoodsMultiTagComponent } from './components/moods-multi-tag/moods-multi-tag.component';
import { MultiTagArtistsComponent } from './components/multi-tag-artists/multi-tag-artists.component';
import { MultiTagModelsComponent } from './components/multi-tag-models/multi-tag-models.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'gallery'},
  { path : 'gallery', component : MoodsGalleryComponent, title : 'Flying PAD | Moods Gallery' },  
  { path : 'mood-details', component : MoodDetailsComponent, title : 'Flying PAD | Mood Details' },
  { path : 'mood-edition', component : MoodEditionComponent, title : 'Flying PAD | Mood Edition' },
  { path : 'create-mood-image', component : CreateMoodImageComponent, title : 'Flying PAD | Create Mood(s)' },
  { path : 'multi-tag', component : MoodsMultiTagComponent, title : 'Flying PAD | Mood Selection' },
  { path : 'multi-tag-artists', component : MultiTagArtistsComponent, title : 'Flying PAD | Multi Tag Artists' },
  { path : 'multi-tag-models', component : MultiTagModelsComponent, title : 'Flying PAD | Multi Tag Models' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MoodsRoutingModule { }