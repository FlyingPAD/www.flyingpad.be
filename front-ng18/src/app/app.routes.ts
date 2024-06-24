import { CanActivateFn, ResolveFn, Router, Routes } from '@angular/router';
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
import { Model } from './models/model';
import { TagList } from './models/tag';
import { TagsService } from './services/tags.service';
import { TestComponent } from './pages/test/test.component';
import { ScriptsComponent } from './pages/scripts/scripts.component';
import { ToolsComponent } from './pages/tools/tools.component';
import { UserService } from './services/user.service';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { HttpEvent, HttpHandlerFn, HttpRequest } from '@angular/common/http';
import { Observable, tap } from 'rxjs';
import { CustomCookieService } from './services/custom-cookie.service';
import { Link, LinkCategoryLight } from './models/link';
import { LinksService } from './services/links.service';
import { MoodLight } from './models/mood';
import { MoodsService } from './services/moods.service';

// Interceptors.
export function authInterceptor(req: HttpRequest<unknown>, next: HttpHandlerFn) : Observable<HttpEvent<unknown>> 
{
  const cookieService = inject(CustomCookieService)
  const token = cookieService.retrieveToken()

  if (token) {
    let clone = req.clone({
      setHeaders:
      {
        Authorization: `Bearer ${token}`
      }
    })

    return next(clone)
  }
  return next(req)
}

// Resolvers.
const modelsResolver : ResolveFn<Model[]> = (route, state) => 
{
    const modelsEditionService = inject(ModelsEditionService)
    return modelsEditionService.getAll()
}

const moodsResolver : ResolveFn<MoodLight[]> = (route, state) => {
    const moodsService = inject(MoodsService)
    return moodsService.getAll()
}

const tagsListResolver : ResolveFn<TagList[]> = (route, state) => 
{
    const tagsService = inject(TagsService)
    return tagsService.getAll()
}

const linksResolver: ResolveFn<any> = (route, state) => {
    const linksService = inject(LinksService)
    const category = route.queryParams['category']
    if(category) {
      return linksService.getLinksByCategory(category).pipe(tap(console.log))
    } 
    return linksService.getAll()
  }

const linkCategoriesResolver : ResolveFn<LinkCategoryLight[]> = (route, state) => {
    const linksService = inject(LinksService)
    return linksService.getCategories()
}

// Guards.
export const homeGuard : CanActivateFn = (route, state) => {
    const userService = inject(UserService)
    const router = inject(Router)
    if(userService.appUser?.role === 2)
    {
        router.navigateByUrl('/dashboard')
        return false
    }
    return true
}
export const dashBoardGuard : CanActivateFn = (route, state) => {
    const userService = inject(UserService)
    const router = inject(Router)
    if(userService.appUser === undefined)
    {
        router.navigateByUrl('/login')
        return false
    }
    return true
}

// Routes.
export const routes: Routes = 
[
    { path : '', component : LayoutFullComponent, children :
        [
            { path : '', pathMatch : 'full', redirectTo : 'home'},
            { path : 'dashboard', component : DashboardComponent, canActivate : [dashBoardGuard], title : 'Flying PAD | Dashboard' },
            { path : 'home', component : HomeComponent, canActivate : [homeGuard], title : 'Flying PAD | Home' },
            { path : 'about', component : AboutComponent, title : 'Flying PAD | About' },
            { path : 'not-found', component : NotFoundComponent, title : 'Flying PAD | Not Found' },
            
            { path : 'moods', loadComponent : () => MoodsComponent, resolve : { moods : moodsResolver }, title : 'Flying PAD | Moods' },
            { path : 'tags', loadComponent : () => TagsComponent, resolve : { tags : tagsListResolver }, title : 'Flying PAD | Tags' },
            { path : 'artists', loadComponent : () => ArtistsComponent, title : 'Flying PAD | Artists' },
            { path : 'models', loadComponent : () => ModelsComponent, resolve : { models : modelsResolver }, title : 'Flying PAD | Models' },
            { path : 'links', loadComponent : () => LinksComponent, resolve : { links : linksResolver, linkCategories : linkCategoriesResolver },
                runGuardsAndResolvers : 'always', title : 'Flying PAD | Links' },
            { path : 'tools', loadComponent : () => ToolsComponent, title : 'Flying PAD | Tools' },
            { path : 'scripts', loadComponent : () => ScriptsComponent, title : 'Flying PAD | Scripts' },

            { path : 'login', component : LoginComponent, title : 'Flying PAD | Login' },
            { path : 'register', component : RegisterComponent, title : 'Flying PAD | Register' },
        ]
    },
    { path : '', component : LayoutEmptyComponent, children :
        [
            { path : 'test', component : TestComponent, resolve : { models : modelsResolver }, title : 'Flying PAD | Test' },
        ]
    },
    { path: '**', redirectTo: '' }
];