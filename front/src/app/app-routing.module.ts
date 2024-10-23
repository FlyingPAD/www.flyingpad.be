import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { UserLoginErrorComponent } from './pages/user-login-error/user-login-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { FlowComponent } from './pages/flow/flow.component';
import { LayoutCustomComponent } from './layouts/layout-custom/layout-custom.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { UserDetailsComponent } from './pages/user-details/user-details.component';
import { UserUpdateComponent } from './pages/user-update/user-update.component';
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
import { CreateMoodImageComponent } from './features/moods/create-mood-image/create-mood-image.component';
import { MultiTagArtistsComponent } from './features/moods/multi-tag-artists/multi-tag-artists.component';
import { MultiTagModelsComponent } from './features/moods/multi-tag-models/multi-tag-models.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { MoodDetailsComponent } from './features/moods/mood-details/mood-details.component';
import { TagsComponent } from './pages/tags/tags.component';
import { ScriptsComponent } from './pages/scripts/scripts.component';
import { ToolsComponent } from './pages/tools/tools.component';
import { MoodsComponent } from './pages/moods/moods.component';
import { MediasComponent } from './pages/medias/medias.component';
import { LinksComponent } from './pages/links/links.component';
import { EditModelsComponent } from './pages/edit-models/edit-models.component';
import { EditFranchisesComponent } from './pages/edit-franchises/edit-franchises.component';
import { EditTagsComponent } from './pages/edit-tags/edit-tags.component';
import { EditLinksComponent } from './pages/edit-links/edit-links.component';
import { EditArtistsComponent } from './pages/edit-artists/edit-artists.component';
import { CreateMoodVideoComponent } from './features/moods/create-mood-video/create-mood-video.component';
import { HiddenMenuWithFooterComponent } from './layouts/hidden-menu-with-footer/hidden-menu-with-footer.component';
import { MediumGalleryComponent } from './pages/medium-gallery/medium-gallery.component';
import { MyAccountComponent } from './pages/my-account/my-account.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { StandardLayoutComponent } from './layouts/standard-layout/standard-layout.component';

const routes: Routes =
  [
    // Layout : Header & Hidden Menu
    {
      path: '', component: LayoutCustomComponent, children:
        [
          { path: '', pathMatch: 'full', redirectTo: 'home' },
          { path: 'home', component: HomeComponent, title: 'Flying PAD | Home' },
          { path: 'not-found', component: NotFoundComponent, title: 'Flying PAD | Not Found' },
          { path: 'login-error', component: UserLoginErrorComponent, title: 'Flying PAD | Login Error' },
          { path: 'register', component: UserRegisterComponent, title: 'Flying PAD | Register' },
          { path: 'medias', component: MediasComponent, title: 'Flying PAD | Medias' },
          { path: 'dashboard', component: DashboardComponent, title: 'Flying PAD | Dashboard' },
        ]
    },

    // Layout : Header, Hidden Menu & Footer
    {
      path: '', component: HiddenMenuWithFooterComponent, children:
        [
          { path: 'about', component: AboutComponent, title: 'Flying PAD | About' },
          { path: 'medium-gallery', component: MediumGalleryComponent, title: 'Flying PAD | Medium Gallery' },
          { path: 'my-account', component: MyAccountComponent, title: 'Flying PAD | My Account' },
          { path: 'settings', component: SettingsComponent, title: 'Flying PAD | Settings' }
        ]
    },

    // Standard Layout
    {
      path: '', component: StandardLayoutComponent, children:
        [

        ]
    },

    // Empty Layout ( for testing purpose )
    {
      path: '', component: LayoutEmptyComponent, children:
        [
          { path: 'flow', component: FlowComponent, title: 'Flying PAD | Flow' },
        ]
    },

    // Artists
    {
      path: 'artists', component: LayoutCustomComponent, children:
        [
          { path: 'edition', component: EditArtistsComponent, title: 'Flying PAD | Edit Artists' },
        ]
    },

    // Moods
    {
      path: 'moods', component: LayoutCustomComponent, children:
        [
          { path: '', component: MoodsComponent, title: 'Flying PAD | Moods Gallery' },
          { path: 'mood-details', component: MoodDetailsComponent, title: 'Flying PAD | Mood Details' },
          { path: 'multi-tag-artists', component: MultiTagArtistsComponent, title: 'Flying PAD | Multi Tag Artists' },
          { path: 'multi-tag-models', component: MultiTagModelsComponent, title: 'Flying PAD | Multi Tag Models' },
          { path: 'create-mood-image', component: CreateMoodImageComponent, title: 'Flying PAD | Create Mood(s)' },
          { path: 'create-mood-video', component: CreateMoodVideoComponent, title: 'Flying PAD | Create Mood(s)' },
        ]
    },

    // Franchises
    {
      path: 'franchises', component: LayoutCustomComponent, children:
        [
          { path: 'edition', component: EditFranchisesComponent, title: 'Flying PAD | Edit Franchises' },
        ]
    },

    // Models
    {
      path: 'models', component: LayoutCustomComponent, children:
        [
          { path: 'edition', component: EditModelsComponent, title: 'Flying PAD | Edit Models' }
        ]
    },

    // Links
    {
      path: 'links', component: LayoutCustomComponent, children:
        [
          { path: '', component: LinksComponent, title: 'Flying PAD | Links Gallery' },
          { path: 'edition', component: EditLinksComponent, title: 'Flying PAD | Edit Links' },
        ]
    },

    // Tags
    {
      path: 'tags', component: LayoutCustomComponent, children:
        [
          { path: '', component: TagsComponent, title: 'Flying PAD | Tags Gallery' },
          { path: 'edition', component: EditTagsComponent, title: 'Flying PAD | Edit Tags' },
        ]
    },

    // Scripts
    {
      path: 'scripts', component: LayoutCustomComponent, children:
        [
          { path: '', component: ScriptsComponent, title: 'Flying PAD | Scripts' },
          { path: 'introduction', component: IntroComponent, title: 'Flying PAD | Introduction' },
          { path: 'piano-reference', component: KeyRefComponent, title: 'Flying PAD | Référence' },
          { path: 'notation', component: NotationComponent, title: 'Flying PAD | La Notation Musicale' },
          { path: 'notes-fr', component: NotesComponent, title: 'Flying PAD | Les Notes' },
          { path: 'notes-en', component: NotesTradComponent, title: 'Flying PAD | Notes' },
          { path: 'notes-ex', component: NotesExComponent, title: 'Flying PAD | Notes - Exercises' },
          { path: 'pulsation', component: PulsationComponent, title: 'Flying PAD | La Pulsation' },
          { path: 'metrics-a', component: MetricsAComponent, title: 'Flying PAD | Les Métriques ( 1 )' },
          { path: 'metrics-b', component: MetricsBComponent, title: 'Flying PAD | Les Métriques ( 2 )' },
          { path: 'intervals', component: IntervalsComponent, title: 'Flying PAD | Les Intervalles' },
          { path: 'chords', component: ChordsComponent, title: 'Flying PAD | Les Accords' },
          { path: 'scales', component: ScalesComponent, title: 'Flying PAD | Les Gammes' },
          { path: 'melody', component: MelodyComponent, title: 'Flying PAD | La Mélodie' },
          { path: 'learn-music', component: LearnMusicComponent, title: 'Flying PAD | Apprendre la Musique' },
          { path: 'viewpoint', component: ViewpointComponent, title: 'Flying PAD | Point de Vue' },
        ]
    },

    // Tools
    {
      path: 'tools', component: LayoutCustomComponent, children:
        [
          { path: '', component: ToolsComponent, title: 'Flying PAD | Tools' },
        ]
    },

    // Users
    {
      path: 'users', component: LayoutCustomComponent, children:
        [
          { path: 'user-details', component: UserDetailsComponent, title: 'Flying PAD | User Details' },
          { path: 'user-update', component: UserUpdateComponent, title: 'Flying PAD | Update User' },
        ]
    },

    // Or else ...
    { path: '**', redirectTo: 'not-found' },
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }