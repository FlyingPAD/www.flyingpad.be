import { Component, inject } from '@angular/core';
import { TagStateService } from '../../services/tag-state.service';

@Component({
  selector: 'app-video-test',
  templateUrl: './video-test.component.html',
  styleUrl: './video-test.component.scss'
})
export class VideoTestComponent 
{
  tagService = inject(TagStateService)

  tagsList = this.tagService.tagsList
}
