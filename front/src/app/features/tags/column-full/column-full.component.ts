import { Component, Input, Output, EventEmitter, OnChanges, SimpleChanges, ChangeDetectorRef } from '@angular/core';
import { TagList } from '../../../interfaces/tags-list';

@Component({
  selector: 'app-column-full',
  templateUrl: './column-full.component.html',
  styleUrls: ['./column-full.component.scss']
})
export class ColumnFullComponent implements OnChanges {
  @Input() currentTagId: number | undefined;
  @Input() currentTagCategoryId: number | undefined;
  @Input() tags: TagList[] | undefined;

  @Output() tagId = new EventEmitter<number>();
  @Output() tagCategoryId = new EventEmitter<number>();
  @Output() moodsByTagCategoryId = new EventEmitter<number>();

  constructor(private cdRef: ChangeDetectorRef) {}

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['currentTagCategoryId']) {
      // Gérer le changement ici
      this.cdRef.markForCheck();
    }
  }

  public handleTagId(tagId: number, tagCategoryId: number): void {
    this.tagId.emit(tagId);
    this.tagCategoryId.emit(tagCategoryId);
  }

  public handleGetMoodsByTagCategoryId(tagCategoryId: number): void {
    this.moodsByTagCategoryId.emit(tagCategoryId);
  }
}