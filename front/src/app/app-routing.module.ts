import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { GalleryComponent } from './links/components/gallery/gallery.component';
import { VideoTestComponent } from './pages/video-test/video-test.component';
import { DemoComponent } from './pages/demo/demo.component';
import { UserLoginErrorComponent } from './pages/user-login-error/user-login-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { FlowComponent } from './pages/flow/flow.component';
import { ModelGalleryComponent } from './features/models/model-gallery/model-gallery.component';
import { EditionComponent } from './features/models/edition/edition.component';
import { LayoutCustomComponent } from './layouts/layout-custom/layout-custom.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';

const routes: Routes = 
[
  { path : '', component : LayoutCustomComponent, children :
    [
      { path : '', pathMatch : 'full', redirectTo : 'home'},
      { path : 'home', component : HomeComponent, title : 'Flying PAD | Home' },
      { path : 'about', component : AboutComponent, title : 'Flying PAD | About' },
      { path : 'not-found', component : NotFoundComponent, title : 'Flying PAD | Not Found' },
      { path : 'video-test', component : VideoTestComponent, title : 'Flying PAD | Video Test' },
      { path : 'login-error', component : UserLoginErrorComponent, title : 'Flying PAD | Login Error' },
      { path : 'register', component : UserRegisterComponent, title : 'Flying PAD | Register' }
    ]
  },

  // Empty Layout ( for testing purpose )
  { path : '', component : LayoutEmptyComponent, children :
    [
      { path : 'demo', component : DemoComponent, title : 'Flying PAD | Demo' },
      { path : 'flow', component : FlowComponent, title : 'Flying PAD | Flow' },
    ]
  },

  // Dashboard
  {
    path : 'dashboard', component : LayoutCustomComponent,
    loadChildren:() => import('./dashboard/dashboard.module').then(m => m.DashboardModule)
  },

  // Artists
  {
    path : 'artists', component : LayoutCustomComponent,
    loadChildren:() => import('./artists/artists.module').then(m => m.ArtistsModule)
  },

  // Franchises
  {
    path : 'franchises', component : LayoutCustomComponent,
    loadChildren:() => import('./franchises/franchises.module').then(m => m.FranchisesModule)
  },
    
  // Media

  // { path : 'medias', component : LayoutCustomComponent, children : 
  //   [
  //     { path : 'media-gallery', component : MediaGalleryComponent, title : 'Flying PAD | Media Gallery' },
  //   ] 
  // },

  // Models
  {
    path : 'models', component : LayoutCustomComponent, children : 
    [
      { path : 'model-gallery', component : ModelGalleryComponent, title : 'Flying PAD | Model Gallery' },
      { path : 'edition', component : EditionComponent, title : 'Flying PAD | Models Edition' }
    ]
  },

  // Moods
  {
    path : 'moods', component : LayoutCustomComponent,
    loadChildren:() => import('./moods/moods.module').then(m => m.MoodsModule)
  },

  // Links
  {
    path : 'links', component : LayoutCustomComponent,
    loadChildren:() => import('./links/links.module').then(m => m.LinksModule)
  },

  { path : 'links/gallery', component : LayoutCustomComponent, children : 
    [
      { path : '', component : GalleryComponent, title : 'Flying PAD | Links Gallery'}
    ]
  },

  // Scripts
  {
    path : 'scripts', component : LayoutCustomComponent,
    loadChildren:() => import('./scripts/scripts.module').then(m => m.ScriptsModule)
  },

  // Tags
  {
    path : 'tags', component : LayoutCustomComponent,
    loadChildren:() => import('./tags/tags.module').then(m => m.TagsModule)
  },

  // Tools
  {
    path : 'tools', component : LayoutCustomComponent,
    loadChildren:() => import('./tools/tools.module').then(m => m.ToolsModule)
  },

  // Users
  {
    path : 'users', component : LayoutCustomComponent,
    loadChildren:() => import('./users/users.module').then(m => m.UsersModule)
  },

  // Or else ...
    { path : '**', redirectTo : 'not-found' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }