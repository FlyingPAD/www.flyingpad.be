import { Component, EventEmitter, Input, Output } from '@angular/core';
import { TagList } from '../../../interfaces/tags-list';

@Component({
  selector: 'app-column-full',
  templateUrl: './column-full.component.html',
  styleUrl: './column-full.component.scss'
})
export class ColumnFullComponent {
  @Input() currentTagId: number | undefined = undefined
  @Input() tags: TagList[] | undefined = undefined
  @Output() tagId = new EventEmitter<number>()

  public handleTagId(tagId: number): void {
    this.tagId.emit(tagId)
  }
}