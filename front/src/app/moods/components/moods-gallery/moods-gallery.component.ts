import { Component, inject } from '@angular/core';
import { MoodStateService } from '../../../core/services/mood-state.service';
import { Router } from '@angular/router';
import { environment } from '../../../../environments/environment';
import { TagStateService } from '../../../core/services/tag-state.service';

@Component({
  selector: 'app-moods-gallery',
  templateUrl: './moods-gallery.component.html',
  styleUrl: './moods-gallery.component.scss'
})
export class MoodsGalleryComponent 
{
  // Properties :

  moodsService = inject(MoodStateService)
  tagsService = inject(TagStateService)
  router = inject(Router)

  environment = environment.apiBaseUrl        // Environment
  moods = this.moodsService.moodsFlow         // Signal
  tagsList = this.tagsService.tagsList        // Signal
  moodsPerPage :  number = 36                 // Pagination : Items per Page
  currentPage :   number = 1                  // Pagination : Current Page

  // Methods :

  //TODO: Make a directive for scrolling & refactor scroll logic
  
  ngOnInit() : void
  {
    window.scrollTo(0, 0)
    const businessIdString = `${this.moods().tagDetails?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  ngAfterViewChecked() : void
  {
    const businessIdString = `${this.moods().tagDetails?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  getMoodRandom() : void
  {
    this.moodsService.updateSelectedMoodId(null)
  }

  updateMoodId( moodId : number | null ) : void
  {
    this.moodsService.updateSelectedMoodId(moodId)
    this.router.navigateByUrl('moods/new-mood')
  }

  updateTagId( tagId : number | null ) : void
  {
    this.moodsService.updateSelectedTagId( tagId )
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