import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { UserService } from './core/services/client/client-user.service';
import { CustomCookieService } from './core/services/system/cookie.service';
import { AuthService } from './core/services/client/client-auth.service';
import { LinkService } from './core/services/client/client-link.service';
import { StateLinksService } from './core/services/state/state-links.service';
import { Subscription, forkJoin } from 'rxjs';
import { LinkCategoryService } from './core/services/client/client-link-category.service';
import { MoodService } from './core/services/client/client-mood.service';
import { TagService } from './core/services/client/client-tag.service';
import { StateMoodsService } from './core/services/state/state-moods.service';
import { StateTagsService } from './core/services/state/state-tags.service';

// Startup | Refresh :

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit, OnDestroy
{ 
  // Injections for Authentication ( Token & User Check )

  #authService = inject(AuthService)
  #userService = inject(UserService)
  #cookieService = inject(CustomCookieService)

  // Injections for Data Gathering :

  #tagsService = inject(TagService)
  #stateTagsService = inject(StateTagsService)
  #moodsService = inject(MoodService)
  #stateMoodsService = inject(StateMoodsService)
  #linksService = inject(LinkService)
  #linkCategoriesService = inject(LinkCategoryService)
  #stateLinksService = inject(StateLinksService)

  // Subscription Property :

  subscription = new Subscription()

  // Initialization : 

  ngOnInit() : void
  {
    // Token Check

    let token = this.#cookieService.retrieveToken()

    if(token)
    {
      this.#userService.setSpecificUser(token)
      this.#authService.acceptConnection()
    }
    else
    {
      this.#userService.setDefaultUser()
    }

    // Data Initialization :

    let requests = forkJoin(
    {
      tags : this.#tagsService.GetTagsList(),
      moods : this.#moodsService.GetAll(),
      links : this.#linksService.GetAll(),
      linkCategories : this.#linkCategoriesService.GetAll()
    })

    this.subscription.add(requests.subscribe({
      next : (data) => 
      {
        this.#stateTagsService.updateCurrentTagList(data.tags.categoriesWithTags)
        this.#stateMoodsService.updateTotalMoods(data.moods.moodsList)
        this.#stateMoodsService.updateCurrentMoodsByTag(data.moods.moodsList)
        this.#stateLinksService.updateTotalLinks(data.links.linksList);
        this.#stateLinksService.updateCurrentLinks(data.links.linksList);
        this.#stateLinksService.updateTotalLinkCategories(data.linkCategories.linkCategories);
      }
    }))
  }

  ngOnDestroy() : void 
  {
    this.subscription.unsubscribe()
  }
}