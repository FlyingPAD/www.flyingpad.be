import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './core/components/about/about.component';
import { HomeComponent } from './core/components/home/home.component';
import { NotFoundComponent } from './core/components/not-found/not-found.component';
import { GalleryComponent } from './links/components/gallery/gallery.component';
import { LayoutCustomComponent } from './core/layouts/layout-custom/layout-custom.component';
import { VideoTestComponent } from './core/components/video-test/video-test.component';
import { DemoComponent } from './core/components/demo/demo.component';
import { LayoutEmptyComponent } from './core/layouts/layout-empty/layout-empty.component';

const routes: Routes = 
[
  // Core
  { path : '', component : LayoutCustomComponent, children :
    [
      { path : '', pathMatch : 'full', redirectTo : 'home'},
      { path : 'home', component : HomeComponent, title : 'Flying PAD | Home' },
      { path : 'about', component : AboutComponent, title : 'Flying PAD | About' },
      { path : 'not-found', component : NotFoundComponent, title : 'Flying PAD | Not Found' },
      { path : 'video-test', component : VideoTestComponent, title : 'Flying PAD | Video Test' },
    ]
  },
  { path : '', component : LayoutEmptyComponent, children :
  [
    { path : 'demo', component : DemoComponent, title : 'Flying PAD | Demo' },
  ]
},

  // Authentication
  {
    path : 'authentication', component : LayoutCustomComponent,
    loadChildren:() => import('./authentication/authentication.module').then(m => m.AuthenticationModule)
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
    path : 'models', component : LayoutCustomComponent,
    loadChildren:() => import('./models/models.module').then(m => m.ModelsModule)
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