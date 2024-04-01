import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ArtistsRoutingModule } from './artists-routing.module';
import { SharedModule } from '../shared/shared.module';

import { LayoutArtistsComponent } from './layouts/layout-artists/layout-artists.component';
import { ArtistsListComponent } from './components/artists-list/artists-list.component';
import { CreateArtistComponent } from './components/create-artist/create-artist.component';
import { CreateStyleComponent } from './components/create-style/create-style.component';
import { UpdateArtistComponent } from './components/update-artist/update-artist.component';
import { UpdateStyleComponent } from './components/update-style/update-style.component';
import { DeleteArtistComponent } from './components/delete-artist/delete-artist.component';
import { DeleteStyleComponent } from './components/delete-style/delete-style.component';
import { ArtistGalleryComponent } from './components/artist-gallery/artist-gallery.component';

@NgModule({
  declarations: 
  [
    LayoutArtistsComponent,
    ArtistsListComponent,
    CreateArtistComponent,
    CreateStyleComponent,
    UpdateArtistComponent,
    UpdateStyleComponent,
    DeleteArtistComponent,
    DeleteStyleComponent,
    ArtistGalleryComponent,
  ],
  imports: 
  [
    CommonModule,
    ArtistsRoutingModule,
    SharedModule
  ]
})
export class ArtistsModule { }