import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { LogInErrorComponent } from './pages/log-in-error/log-in-error.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { CreateMoodImageComponent } from './pages/create-mood-image/create-mood-image.component';
import { MultiTagArtistsComponent } from './pages/multi-tag-artists/multi-tag-artists.component';
import { MultiTagModelsComponent } from './pages/multi-tag-models/multi-tag-models.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { TagsComponent } from './pages/tags/tags.component';
import { ScriptsComponent } from './pages/scripts/scripts.component';
import { ToolsComponent } from './pages/tools/tools.component';
import { MediaComponent } from './pages/media/media.component';
import { LinksComponent } from './pages/links/links.component';
import { EditModelsComponent } from './pages/edit-models/edit-models.component';
import { EditFranchisesComponent } from './pages/edit-franchises/edit-franchises.component';
import { EditTagsComponent } from './pages/edit-tags/edit-tags.component';
import { EditLinksComponent } from './pages/edit-links/edit-links.component';
import { EditArtistsComponent } from './pages/edit-artists/edit-artists.component';
import { CreateMoodVideoComponent } from './pages/create-mood-video/create-mood-video.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { LayoutHomeComponent } from './layouts/layout-home/layout-home.component';
import { SignUpComponent } from './pages/sign-up/sign-up.component';
import { LogInComponent } from './pages/log-in/log-in.component';
import { LayoutMoodsComponent } from './layouts/layout-moods/layout-moods.component';
import { LayoutToolsComponent } from './layouts/layout-tools/layout-tools.component';
import { LayoutAboutComponent } from './layouts/layout-about/layout-about.component';
import { authGuard } from './guards/auth.guard';
import { MultiTagTagsComponent } from './pages/multi-tag-tags/multi-tag-tags.component';
import { CentralGalleryComponent } from './pages/central-gallery/central-gallery.component';
import { EditMoodComponent } from './pages/edit-mood/edit-mood.component';
import { MultiTagComponent } from './pages/multi-tag/multi-tag.component';
import { CreateMoodVideoYoutubeComponent } from './pages/create-mood-video-youtube/create-mood-video-youtube.component';
import { CreateMoodAudioSoundcloudComponent } from './pages/create-mood-audio-soundcloud/create-mood-audio-soundcloud.component';
import { ConfirmEmailComponent } from './pages/confirm-email/confirm-email.component';
import { LadderComponent } from './pages/ladder/ladder.component';
import { UserLeagueComponent } from './pages/user-league/user-league.component';
import { UserProfilePublicComponent } from './pages/user-profile-public/user-profile-public.component';
import { NotesComponent } from './pages/notes/notes.component';

const routes: Routes = [
  // Layout ' Home '.
  {
    path: '', component: LayoutHomeComponent, children: [
      { path: '', pathMatch: 'full', redirectTo: 'home' },
      { path: 'home', component: HomeComponent, title: 'Flying PAD | Home' },
    ]
  },

  // Layout ' About '.
  {
    path: '', component: LayoutAboutComponent, children: [
      { path: 'about', component: AboutComponent, title: 'Flying PAD | About' },
    ]
  },

  // Layout ' Moods '.
  {
    path: '', component: LayoutMoodsComponent, children: [
      { path: 'central-gallery', component: CentralGalleryComponent, title: 'Flying PAD | Moods Gallery' },
      { path: 'moods/multi-tag', component: MultiTagComponent, title: 'Flying PAD | Multi Tag' },
      { path: 'moods/multi-tag-artists', component: MultiTagArtistsComponent, title: 'Flying PAD | Multi Tag Artists' },
      { path: 'moods/multi-tag-models', component: MultiTagModelsComponent, title: 'Flying PAD | Multi Tag Models' },
      { path: 'moods/multi-tag-tags', component: MultiTagTagsComponent, title: 'Flying PAD | Multi Tag Tags' },
      { path: 'moods/create-mood-image', component: CreateMoodImageComponent, title: 'Flying PAD | Create Image(s)' },
      { path: 'moods/create-mood-video', component: CreateMoodVideoComponent, title: 'Flying PAD | Create Video(s)' },
      { path: 'moods/create-mood-video-youtube', component: CreateMoodVideoYoutubeComponent, title: 'Flying PAD | Create YouTube Video(s)' },
      { path: 'moods/create-mood-audio-soundcloud', component: CreateMoodAudioSoundcloudComponent, title: 'Flying PAD | Create SoundCloud Audio' },
      { path: 'moods/edit-mood', component: EditMoodComponent, title: 'Flying PAD | Edit Mood' },
      { path: 'tags', component: TagsComponent, title: 'Flying PAD | Tags Gallery' },
      { path: 'media', component: MediaComponent, title: 'Flying PAD | Media' },
      { path: 'not-found', component: NotFoundComponent, title: 'Flying PAD | Not Found' }
    ]
  },

  // Layout ' Tools '.
  {
    path: '', component: LayoutToolsComponent, children: [
      { path: 'dashboard', component: DashboardComponent, canActivate: [authGuard], title: 'Flying PAD | Dashboard' },
      { path: 'tools', component: ToolsComponent, title: 'Flying PAD | Tools' },
      { path: 'scripts', component: ScriptsComponent, title: 'Flying PAD | Scripts' },
      { path: 'links', component: LinksComponent, title: 'Flying PAD | Links Gallery' },
      { path: 'links/edition', component: EditLinksComponent, title: 'Flying PAD | Edit Links' },
      { path: 'artists/edition', component: EditArtistsComponent, title: 'Flying PAD | Edit Artists' },
      { path: 'tags/edition', component: EditTagsComponent, title: 'Flying PAD | Edit Tags' },
      { path: 'models/edition', component: EditModelsComponent, title: 'Flying PAD | Edit Models' },
      { path: 'franchises/edition', component: EditFranchisesComponent, title: 'Flying PAD | Edit Franchises' },
      { path: 'settings', component: SettingsComponent, title: 'Flying PAD | Settings' }
    ]
  },

  // Empty Layout
  {
    path: '', component: LayoutEmptyComponent, children: [
      { path: 'log-in', component: LogInComponent, title: 'Flying PAD | Log in' },
      { path: 'log-in/error', component: LogInErrorComponent, title: 'Flying PAD | Log in Error' },
      { path: 'sign-up', component: SignUpComponent, title: 'Flying PAD | Sign up' },
      { path: 'confirm-email/:token', component: ConfirmEmailComponent, title: 'Flying PAD | Confirm e-Mail' },
      { path: 'ladder', component: LadderComponent, title: 'Flying PAD | Ladder' },
      { path: 'user-league', component: UserLeagueComponent, title: 'Flying PAD | Ladder' },
      { path: 'user-profile', component: UserProfilePublicComponent, title: 'Flying PAD | User Profile' },
      { path: 'notes', component: NotesComponent, title: 'Flying PAD | Notes' }
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