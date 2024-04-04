import { Component, inject } from '@angular/core';
import { MoodStateService } from '../../../core/services/mood-state.service';
import { TagStateService } from '../../../core/services/tag-state.service';

@Component({
  selector: 'app-tags-wall',
  templateUrl: './tags-wall.component.html',
  styleUrl: './tags-wall.component.scss'
})
export class TagsWallComponent 
{
  #tagsService = inject(TagStateService)
  #moodsService = inject(MoodStateService)

  tagsList = this.#tagsService.tagsList
  moods = this.#moodsService.moodsFlow

  updateTagId( tagId : number | null)
  {
    this.#moodsService.updateSelectedTagId( tagId )
  }
}