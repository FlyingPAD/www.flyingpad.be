import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { UserLoginErrorComponent } from './pages/user-login-error/user-login-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { CreateMoodImageComponent } from './features/moods/create-mood-image/create-mood-image.component';
import { MultiTagArtistsComponent } from './features/moods/multi-tag-artists/multi-tag-artists.component';
import { MultiTagModelsComponent } from './features/moods/multi-tag-models/multi-tag-models.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { TagsComponent } from './pages/tags/tags.component';
import { ScriptsComponent } from './pages/scripts/scripts.component';
import { ToolsComponent } from './pages/tools/tools.component';
import { MoodsComponent } from './pages/moods/moods.component';
import { MediaComponent } from './pages/media/media.component';
import { LinksComponent } from './pages/links/links.component';
import { EditModelsComponent } from './pages/edit-models/edit-models.component';
import { EditFranchisesComponent } from './pages/edit-franchises/edit-franchises.component';
import { EditTagsComponent } from './pages/edit-tags/edit-tags.component';
import { EditLinksComponent } from './pages/edit-links/edit-links.component';
import { EditArtistsComponent } from './pages/edit-artists/edit-artists.component';
import { CreateMoodVideoComponent } from './features/moods/create-mood-video/create-mood-video.component';
import { MediumGalleryComponent } from './pages/medium-gallery/medium-gallery.component';
import { SettingsComponent } from './pages/settings/settings.component';
import { LayoutHomeComponent } from './layouts/layout-home/layout-home.component';
import { SignUpComponent } from './pages/sign-up/sign-up.component';
import { LogInComponent } from './pages/log-in/log-in.component';
import { LayoutMoodsComponent } from './layouts/layout-moods/layout-moods.component';
import { LayoutToolsComponent } from './layouts/layout-tools/layout-tools.component';
import { LayoutAboutComponent } from './layouts/layout-about/layout-about.component';

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
      { path: 'moods', component: MoodsComponent, title: 'Flying PAD | Moods Gallery' },
      { path: 'moods/multi-tag-artists', component: MultiTagArtistsComponent, title: 'Flying PAD | Multi Tag Artists' },
      { path: 'moods/multi-tag-models', component: MultiTagModelsComponent, title: 'Flying PAD | Multi Tag Models' },
      { path: 'moods/create-mood-image', component: CreateMoodImageComponent, title: 'Flying PAD | Create Mood(s)' },
      { path: 'moods/create-mood-video', component: CreateMoodVideoComponent, title: 'Flying PAD | Create Mood(s)' },
      { path: 'tags', component: TagsComponent, title: 'Flying PAD | Tags Gallery' },
      { path: 'media', component: MediaComponent, title: 'Flying PAD | Media' },
      { path: 'not-found', component: NotFoundComponent, title: 'Flying PAD | Not Found' },
      { path: 'login-error', component: UserLoginErrorComponent, title: 'Flying PAD | Login Error' },
      { path: 'register', component: UserRegisterComponent, title: 'Flying PAD | Register' },
      { path: 'medium-gallery', component: MediumGalleryComponent, title: 'Flying PAD | Medium Gallery' },
    ]
  },

  // Layout ' Tools '.
  {
    path: '', component: LayoutToolsComponent, children: [
      { path: 'dashboard', component: DashboardComponent, title: 'Flying PAD | Dashboard' },
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
      { path: 'sign-up', component: SignUpComponent, title: 'Flying PAD | Sign up' },
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