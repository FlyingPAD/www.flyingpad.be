import { Component, EventEmitter, Input, Output } from '@angular/core';
import { TagLight } from '../../../interfaces/tag';

@Component({
  selector: 'app-related-tags',
  templateUrl: './related-tags.component.html',
  styleUrl: './related-tags.component.scss'
})
export class RelatedTagsComponent {
  @Input() currentTagId: number | undefined = undefined
  @Input() relatedTags: TagLight[] | undefined = undefined
  @Output() tagId = new EventEmitter<number>()

  public handleTagId(tagId: number): void {
    this.tagId.emit(tagId)
  }
}