import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { UserLoginErrorComponent } from './pages/user-login-error/user-login-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { FlowComponent } from './pages/flow/flow.component';
import { ModelGalleryComponent } from './features/models/model-gallery/model-gallery.component';
import { EditionComponent } from './features/models/edition/edition.component';
import { LayoutCustomComponent } from './layouts/layout-custom/layout-custom.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { UserDetailsComponent } from './features/users/user-details/user-details.component';
import { UserUpdateComponent } from './features/users/user-update/user-update.component';
import { ChordWheelSvgComponent } from './features/tools/chord-wheel-svg/chord-wheel-svg.component';
import { CircleOfFifthsComponent } from './features/tools/circle-of-fifths/circle-of-fifths.component';
import { DiapasonComponent } from './features/tools/diapason/diapason.component';
import { FlyingKeysMiniComponent } from './features/tools/flying-keys-mini/flying-keys-mini.component';
import { ToolListComponent } from './features/tools/tool-list/tool-list.component';
import { TrainerNotesComponent } from './features/tools/trainer-notes/trainer-notes.component';
import { TagsGalleryComponent } from './features/tags/tags-gallery/tags-gallery.component';
import { ListComponent } from './features/scripts/list/list.component';
import { ChordsComponent } from './features/scripts/chords/chords.component';
import { IntervalsComponent } from './features/scripts/intervals/intervals.component';
import { IntroComponent } from './features/scripts/intro/intro.component';
import { KeyRefComponent } from './features/scripts/key-ref/key-ref.component';
import { LearnMusicComponent } from './features/scripts/learn-music/learn-music.component';
import { MelodyComponent } from './features/scripts/melody/melody.component';
import { MetricsAComponent } from './features/scripts/metrics-a/metrics-a.component';
import { MetricsBComponent } from './features/scripts/metrics-b/metrics-b.component';
import { NotationComponent } from './features/scripts/notation/notation.component';
import { NotesExComponent } from './features/scripts/notes-ex/notes-ex.component';
import { NotesTradComponent } from './features/scripts/notes-trad/notes-trad.component';
import { NotesComponent } from './features/scripts/notes/notes.component';
import { PulsationComponent } from './features/scripts/pulsation/pulsation.component';
import { ScalesComponent } from './features/scripts/scales/scales.component';
import { ViewpointComponent } from './features/scripts/viewpoint/viewpoint.component';
import { MoodsGalleryComponent } from './features/moods/moods-gallery/moods-gallery.component';
import { CreateMoodImageComponent } from './features/moods/create-mood-image/create-mood-image.component';
import { MoodEditionComponent } from './features/moods/mood-edition/mood-edition.component';
import { MoodsMultiTagComponent } from './features/moods/moods-multi-tag/moods-multi-tag.component';
import { MultiTagArtistsComponent } from './features/moods/multi-tag-artists/multi-tag-artists.component';
import { MultiTagModelsComponent } from './features/moods/multi-tag-models/multi-tag-models.component';
import { DashboardHomeComponent } from './pages/dashboard-home/dashboard-home.component';
import { FranchiseGalleryComponent } from './features/franchises/franchise-gallery/franchise-gallery.component';
import { MediaGalleryComponent } from './features/franchises/media-gallery/media-gallery.component';
import { ArtistGalleryComponent } from './features/artists/artist-gallery/artist-gallery.component';
import { ArtistsListComponent } from './features/artists/artists-list/artists-list.component';
import { CreateArtistComponent } from './features/artists/create-artist/create-artist.component';
import { CreateStyleComponent } from './features/artists/create-style/create-style.component';
import { DeleteArtistComponent } from './features/artists/delete-artist/delete-artist.component';
import { DeleteStyleComponent } from './features/artists/delete-style/delete-style.component';
import { UpdateArtistComponent } from './features/artists/update-artist/update-artist.component';
import { UpdateStyleComponent } from './features/artists/update-style/update-style.component';
import { LinksEditionComponent } from './features/links/links-edition/links-edition.component';
import { LinksGalleryComponent } from './features/links/links-gallery/links-gallery.component';
import { FranchisesGalleryComponent } from './features/franchises/franchises-gallery/franchises-gallery.component';
import { MoodDetailsComponent } from './features/moods/mood-details/mood-details.component';
import { LayoutArtistsComponent } from './layouts/layout-artists/layout-artists.component';

const routes: Routes = 
[
  { path : '', component : LayoutCustomComponent, children :
    [
      { path : '', pathMatch : 'full', redirectTo : 'home'},
      { path : 'home', component : HomeComponent, title : 'Flying PAD | Home' },
      { path : 'about', component : AboutComponent, title : 'Flying PAD | About' },
      { path : 'not-found', component : NotFoundComponent, title : 'Flying PAD | Not Found' },
      { path : 'login-error', component : UserLoginErrorComponent, title : 'Flying PAD | Login Error' },
      { path : 'register', component : UserRegisterComponent, title : 'Flying PAD | Register' },
      { path : 'dashboard', component : DashboardHomeComponent, title : 'Flying PAD | Dashboard' },
    ]
  },

  // Empty Layout ( for testing purpose )
  { path : '', component : LayoutEmptyComponent, children :
    [
      { path : 'flow', component : FlowComponent, title : 'Flying PAD | Flow' },
    ]
  },

  // Artists
  { path : 'artists', component : LayoutCustomComponent, children :
    [
      { path : 'artist-gallery', component : ArtistGalleryComponent, title : 'Flying PAD | Artist Gallery' },
    
      { path : 'update-artist', component : UpdateArtistComponent, title : 'Flying PAD | Update Artist' },
      { path : 'update-style', component : UpdateStyleComponent, title : 'Flying PAD | Update Style' },

      { path : 'create-artist', component : CreateArtistComponent, title : 'Flying PAD | Create Artist' },
      { path : 'create-style', component : CreateStyleComponent, title : 'Flying PAD | Create Style' },
      { path : 'delete-artist', component : DeleteArtistComponent, title : 'Flying PAD | Delete Artist' },
      { path : 'delete-style', component : DeleteStyleComponent, title : 'Flying PAD | Delete Style' },
      { path : 'list', component : LayoutArtistsComponent, children :
        [
          { path : '', component : ArtistsListComponent, title : 'Flying PAD | Artists' },
        ]
      },
    ]
  },

  // Franchises
  { path : 'franchises', component : LayoutCustomComponent, children :
    [
      { path : 'franchise-gallery', component : FranchiseGalleryComponent, title : 'Flying PAD | Franchise Gallery' },
      { path : 'gallery', component : FranchisesGalleryComponent, title : 'Flying PAD | Franchises Gallery' },
      { path : 'media-gallery', component : MediaGalleryComponent, title : 'Flying PAD | Media Gallery' },
      { path : 'edition', component : EditionComponent, title : 'Flying PAD | Franchises CRUD' },
    ]
  },

  // Models
  { path : 'models', component : LayoutCustomComponent, children : 
    [
      { path : 'model-gallery', component : ModelGalleryComponent, title : 'Flying PAD | Model Gallery' },
      { path : 'edition', component : EditionComponent, title : 'Flying PAD | Models Edition' }
    ]
  },

  // Moods
  { path : 'moods', component : LayoutCustomComponent, children : 
    [
      { path : '', component : MoodsGalleryComponent, title : 'Flying PAD | Moods Gallery' },  
      { path : 'mood-details', component : MoodDetailsComponent, title : 'Flying PAD | Mood Details' },
      { path : 'mood-edition', component : MoodEditionComponent, title : 'Flying PAD | Mood Edition' },
      { path : 'create-mood-image', component : CreateMoodImageComponent, title : 'Flying PAD | Create Mood(s)' },
      { path : 'multi-tag', component : MoodsMultiTagComponent, title : 'Flying PAD | Mood Selection' },
      { path : 'multi-tag-artists', component : MultiTagArtistsComponent, title : 'Flying PAD | Multi Tag Artists' },
      { path : 'multi-tag-models', component : MultiTagModelsComponent, title : 'Flying PAD | Multi Tag Models' },
    ]
  },

  // Links
  { path : 'links', component : LayoutCustomComponent, children : 
    [
      { path : '', component : LinksGalleryComponent, title : 'Flying PAD | Links Gallery' },
      { path : 'edition', component : LinksEditionComponent, title : 'Flying PAD | Links Edition' },
    ]
  },

  // Scripts
  { path : 'scripts', component : LayoutCustomComponent, children : 
    [
      { path : '', component : ListComponent, title : 'Flying PAD | Tools List' },  
      { path : 'introduction', component : IntroComponent, title : 'Flying PAD | Introduction' },
      { path : 'piano-reference', component : KeyRefComponent, title : 'Flying PAD | Référence' },
      { path : 'notation', component : NotationComponent, title : 'Flying PAD | La Notation Musicale' },      
      { path : 'notes-fr', component : NotesComponent, title : 'Flying PAD | Les Notes' },
      { path : 'notes-en', component : NotesTradComponent, title : 'Flying PAD | Notes' },
      { path : 'notes-ex', component : NotesExComponent, title : 'Flying PAD | Notes - Exercises' },
      { path : 'pulsation', component : PulsationComponent, title : 'Flying PAD | La Pulsation' },
      { path : 'metrics-a', component : MetricsAComponent, title : 'Flying PAD | Les Métriques ( 1 )' },
      { path : 'metrics-b', component : MetricsBComponent, title : 'Flying PAD | Les Métriques ( 2 )' },
      { path : 'intervals', component : IntervalsComponent, title : 'Flying PAD | Les Intervalles' },
      { path : 'chords', component : ChordsComponent, title : 'Flying PAD | Les Accords' },
      { path : 'scales', component : ScalesComponent, title : 'Flying PAD | Les Gammes' },
      { path : 'melody', component : MelodyComponent, title : 'Flying PAD | La Mélodie' },
      { path : 'learn-music', component : LearnMusicComponent, title : 'Flying PAD | Apprendre la Musique' },
      { path : 'viewpoint', component : ViewpointComponent, title : 'Flying PAD | Point de Vue' },
    ]
  },

  // Tags
  { path : 'tags', component : LayoutCustomComponent, children : 
    [
      { path : '', component : TagsGalleryComponent, title : 'Flying PAD | Tags Gallery' },  
      { path : 'edition', component : EditionComponent, title : 'Flying PAD | Tags CRUD' },  
    ]
  },

  // Tools
  { path : 'tools', component : LayoutCustomComponent, children : 
    [
      { path : '', component : ToolListComponent, title : 'Flying PAD | Tools List' },    
      { path : 'chord-wheel', component : ChordWheelSvgComponent, title : 'Flying PAD | Chord Wheel' },
      { path : 'circle-of-fifths', component : CircleOfFifthsComponent, title : 'Flying PAD | Circle of Fifths' },
      { path : 'diapason', component : DiapasonComponent, title : 'Flying PAD | Diapason' },
      { path : 'flying-keys-mini', component : FlyingKeysMiniComponent, title : 'Flying PAD | Flying Keys ( Mini )' },
      { path : 'trainer-notes', component : TrainerNotesComponent, title : 'Flying PAD | Notes Trainer' },
    ]
  },

  // Users
  { path : 'users', component : LayoutCustomComponent, children : 
    [
      { path : 'user-details', component : UserDetailsComponent, title : 'Flying PAD | User Details' },
      { path : 'user-update', component : UserUpdateComponent, title : 'Flying PAD | Update User' },
    ]
  },

  // Or else ...
    { path : '**', redirectTo : 'not-found' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }