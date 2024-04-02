import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { MoodService } from '../../../core/services/client/client-mood.service';
import { environment } from '../../../../environments/environment';
import { UserService } from '../../../core/services/client/client-user.service';
import { TagService } from '../../../core/services/client/client-tag.service';
import { StateTagsService } from '../../../core/services/state/state-tags.service';
import { StateMoodsService } from '../../../core/services/state/state-moods.service';
import { Subscription } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { Tag } from '../../../core/models/tag';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';
import { MoodLight } from '../../../core/models/mood';

@Component({
  selector: 'app-moods-gallery',
  templateUrl: './moods-gallery.component.html',
  styleUrl: './moods-gallery.component.scss'
})
export class MoodsGalleryComponent implements OnInit, OnDestroy
{
  // Injections for Display Rights

  userService = inject(UserService)
  
  // Injection for Manipulationg Data

  #moodService = inject(MoodService)
  #tagsService = inject(TagService)
  #stateTagsService = inject(StateTagsService)
  #stateMoodsService = inject(StateMoodsService)
  menuMobileService = inject(MenuMobileService)
  
  // Injection for Component Routing

  #route = inject(ActivatedRoute)
  
  // Properties :
  
  environment = environment.apiBaseUrl
  tagId = this.#route.snapshot.params['id']

  currentTagList$ = this.#stateTagsService.currentTagList$
  currentMoods$ = this.#stateMoodsService.currentMoodsByTag$
  currentTag$ = this.#stateTagsService.currentTag$

  moodsSubscription = new Subscription()
  tagSubscription = new Subscription()

  moods : MoodLight[] = []

  // Pagination :

  moodsPerPage :  number = 36    // Items per Page
  currentPage :   number = 1     // Current Page

  ngOnInit() : void
  {
    window.scrollTo(0, 0)
    this.scrollToStart( this.tagId )

    if(this.tagId)
    {
      this.getMoodsByTag(this.tagId)
    }
    else
    {
      this.getAllMoods()
      this.#stateTagsService.updateCurrentTag( new Tag() )
    }
  }

  ngOnDestroy() : void 
  {
    this.moodsSubscription.unsubscribe()
    this.tagSubscription.unsubscribe()
  }

  getMoodsByTag( tagId : number)
  {
    this.moodsSubscription = this.#moodService.GetByTag( tagId ).subscribe({
      next : (data) => 
      {
        this.#stateMoodsService.updateCurrentMoodsByTag(data.moods)
        this.currentMoods$ = this.#stateMoodsService.currentMoodsByTag$
        this.moods = data.moods

        this.tagSubscription = this.#tagsService.GetOneDetails( tagId ).subscribe({
          next : (data) => {
            this.#stateTagsService.updateCurrentTag(data.tag)
            this.scrollToStart( data.tag.businessId.toString() )
          }
        })
      }
    })
  }

  getAllMoods()
  {
    this.currentMoods$ = this.#stateMoodsService.totalMoods$
  }

  scrollToStart( elementId : string ) : void 
  {
    const domElement = document.getElementById( elementId )

    if (domElement) 
    {
      domElement.scrollIntoView({ behavior: "smooth", block: "center", inline: "nearest" });
    }
  }
}