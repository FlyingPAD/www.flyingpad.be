import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './core/components/about/about.component';
import { HomeComponent } from './core/components/home/home.component';
import { NotFoundComponent } from './core/components/not-found/not-found.component';
import { LayoutCoreComponent } from './core/layouts/layout-core/layout-core.component';
import { GalleryComponent } from './links/components/gallery/gallery.component';
import { LayoutStandardComponent } from './core/layouts/layout-standard/layout-standard.component';

const routes: Routes = 
[
  // Core
  
  { path : '', component : LayoutStandardComponent, children :
    [
      { path : '', pathMatch : 'full', redirectTo : 'home'},
      { path : 'home', component : HomeComponent, title : 'Flying PAD | Home' },
      { path : 'about', component : AboutComponent, title : 'Flying PAD | About' },
      { path : 'not-found', component : NotFoundComponent, title : 'Flying PAD | Not Found' },
    ]
  },

  // Authentication

  {
    path : 'authentication', component : LayoutStandardComponent,
    loadChildren:() => import('./authentication/authentication.module').then(m => m.AuthenticationModule)
  },

  // Dashboard

  {
    path : 'dashboard', component : LayoutStandardComponent,
    loadChildren:() => import('./dashboard/dashboard.module').then(m => m.DashboardModule)
  },

  // Artists

  {
    path : 'artists', component : LayoutStandardComponent,
    loadChildren:() => import('./artists/artists.module').then(m => m.ArtistsModule)
  },

  // Franchises

  {
    path : 'franchises', component : LayoutStandardComponent,
    loadChildren:() => import('./franchises/franchises.module').then(m => m.FranchisesModule)
  },
    
  // Models

  {
    path : 'models', component : LayoutStandardComponent,
    loadChildren:() => import('./models/models.module').then(m => m.ModelsModule)
  },

  // Moods

  {
    path : 'moods', component : LayoutStandardComponent,
    loadChildren:() => import('./moods/moods.module').then(m => m.MoodsModule)
  },

  // Links

  {
    path : 'links', component : LayoutStandardComponent,
    loadChildren:() => import('./links/links.module').then(m => m.LinksModule)
  },

  { path : 'links/gallery', component : LayoutStandardComponent, children : 
    [
      { path : '', component : GalleryComponent, title : 'Flying PAD | Links Gallery'}
    ]
  },

  // Scripts

  {
    path : 'scripts', component : LayoutStandardComponent,
    loadChildren:() => import('./scripts/scripts.module').then(m => m.ScriptsModule)
  },

  // Tags

  {
    path : 'tags', component : LayoutStandardComponent,
    loadChildren:() => import('./tags/tags.module').then(m => m.TagsModule)
  },

  // Tools

  {
    path : 'tools', component : LayoutStandardComponent,
    loadChildren:() => import('./tools/tools.module').then(m => m.ToolsModule)
  },

  // Users

  {
    path : 'users', component : LayoutStandardComponent,
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