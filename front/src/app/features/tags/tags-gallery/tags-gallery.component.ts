import { Component, OnInit, inject } from '@angular/core';
import { TagStateService } from '../../../services/tag-state.service';
import { MoodStateService } from '../../../services/mood.service';

@Component({
  selector: 'app-tags-gallery',
  templateUrl: './tags-gallery.component.html',
  styleUrl: './tags-gallery.component.scss'
})
export class TagsGalleryComponent implements OnInit
{
  #tagsService = inject(TagStateService)
  #moodsService = inject(MoodStateService)

  tagsList = this.#tagsService.tagsList
  moods = this.#moodsService.moodsFlow

  ngOnInit() : void
  {
    window.scrollTo(0, 0)
    const businessIdString = `${this.moods().tagDetails?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  updateTagId( tagId : number | null)
  {
    this.#moodsService.updateSelectedTagId( tagId )
    this.#moodsService.updateSelectedGalleryType('tag')
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