import { Component, inject } from '@angular/core';
import { TagStateService } from '../../../core/services/tag-state.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.scss'
})
export class ListComponent 
{
  tagService = inject(TagStateService)

  tagsFlow = this.tagService.tags

  mpp : number = 36
  p : number = 1

  updateTagId( tagId : number )
  {

  }
}