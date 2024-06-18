import { ResolveFn, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { AboutComponent } from './pages/about/about.component';
import { LayoutFullComponent } from './layouts/layout-full/layout-full.component';
import { LoginComponent } from './pages/login/login.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { RegisterComponent } from './pages/register/register.component';
import { ModelsComponent } from './pages/models/models.component';
import { LinksComponent } from './pages/links/links.component';
import { ArtistsComponent } from './pages/artists/artists.component';
import { MoodsComponent } from './pages/moods/moods.component';
import { TagsComponent } from './pages/tags/tags.component';
import { ModelsEditionService } from './services/models-edition.service';
import { inject } from '@angular/core';
import { Model } from './models/models';

const modelsResolver: ResolveFn<Model[]> = (route, state) => {
    const modelsEditionService = inject(ModelsEditionService);
    return modelsEditionService.getAll();
  }

export const routes: Routes = 
[
    { path : '', component : LayoutFullComponent, children :
        [
            { path : '', pathMatch : 'full', redirectTo : 'home'},
            { path : 'home', component : HomeComponent, title : 'Flying PAD | Home' },
            { path : 'about', component : AboutComponent, title : 'Flying PAD | About' },
            { path : 'not-found', component : NotFoundComponent, title : 'Flying PAD | Not Found' },
            
            { path : 'moods', loadComponent : () => MoodsComponent, title : 'Flying PAD | Moods' },
            { path : 'tags', loadComponent : () => TagsComponent, title : 'Flying PAD | Tags' },
            { path : 'artists', loadComponent : () => ArtistsComponent, title : 'Flying PAD | Artists' },
            { path : 'models', loadComponent : () => ModelsComponent, resolve : { models : modelsResolver }, title : 'Flying PAD | Models' },
            { path : 'links', loadComponent : () => LinksComponent, title : 'Flying PAD | Links' },

            { path : 'login', component : LoginComponent, title : 'Flying PAD | Login' },
            { path : 'register', component : RegisterComponent, title : 'Flying PAD | Register' },
        ]
    },
    { path: '**', redirectTo: '' }
];