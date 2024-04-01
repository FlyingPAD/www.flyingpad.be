import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { StateTagsService } from '../../../core/services/state/state-tags.service';

@Component({
  selector: 'app-tags-wall',
  templateUrl: './tags-wall.component.html',
  styleUrl: './tags-wall.component.scss'
})
export class TagsWallComponent 
{
  #stateTagsService = inject(StateTagsService)
  #router = inject(Router)

  currentTagList$ = this.#stateTagsService.currentTagList$

  ngOnInit()
  {
    window.scrollTo(0, 0)
  }

  selectMoods( tagId : number)
  {
    this.#router.navigateByUrl('moods/gallery/' + tagId)
  }
}