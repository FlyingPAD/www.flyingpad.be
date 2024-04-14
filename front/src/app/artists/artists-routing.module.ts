import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LayoutArtistsComponent } from './layouts/layout-artists/layout-artists.component';

import { ArtistGalleryComponent } from './components/artist-gallery/artist-gallery.component';

import { ArtistsListComponent } from './components/artists-list/artists-list.component';
import { CreateArtistComponent } from './components/create-artist/create-artist.component';
import { CreateStyleComponent } from './components/create-style/create-style.component';
import { UpdateArtistComponent } from './components/update-artist/update-artist.component';
import { UpdateStyleComponent } from './components/update-style/update-style.component';
import { DeleteArtistComponent } from './components/delete-artist/delete-artist.component';
import { DeleteStyleComponent } from './components/delete-style/delete-style.component';


const routes: Routes = 
[
  { path : '', component : LayoutArtistsComponent, children :
    [
      { path : '', pathMatch : 'full', redirectTo : 'list'},
      { path : 'list', component : ArtistsListComponent, title : 'Flying PAD | Artists' },
    
      { path : 'update-artist', component : UpdateArtistComponent, title : 'Flying PAD | Update Artist' },
      { path : 'update-style', component : UpdateStyleComponent, title : 'Flying PAD | Update Style' },

      { path : 'create-artist', component : CreateArtistComponent, title : 'Flying PAD | Create Artist' },
      { path : 'create-style', component : CreateStyleComponent, title : 'Flying PAD | Create Style' },
      { path : 'delete-artist', component : DeleteArtistComponent, title : 'Flying PAD | Delete Artist' },
      { path : 'delete-style', component : DeleteStyleComponent, title : 'Flying PAD | Delete Style' },
    ] 
  },
  { path : 'artist-gallery', component : ArtistGalleryComponent, title : 'Flying PAD | Artist Gallery' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ArtistsRoutingModule { }