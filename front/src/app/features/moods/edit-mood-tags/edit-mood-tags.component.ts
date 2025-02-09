import { Component, Input, OnDestroy, OnInit, Output, EventEmitter, inject } from '@angular/core'
import { Subscription } from 'rxjs'
import { FlowService } from '../../../services/flow.service'
import { MoodFull } from '../../../interfaces/mood'
import { TagsCheckBoxesList } from '../../../interfaces/tags-list'

@Component({
  selector: 'app-edit-mood-tags',
  templateUrl: './edit-mood-tags.component.html',
  styleUrls: ['./edit-mood-tags.component.scss']
})
export class EditMoodTagsComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)

  @Input() mood!: MoodFull
  @Output() tagsSelected = new EventEmitter<number[]>()

  #subscription = new Subscription()
  public tagsList!: TagsCheckBoxesList[]
  
  
  ngOnInit(): void {
    this.#subscription = this.#flowService.getTagsCheckBoxByMood(this.mood.businessId).subscribe({
      next: (data) => {
        this.tagsList = data
        this.emitSelectedTags()
      }
    })
  }

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  private emitSelectedTags(): void {
    const selectedIds = this.tagsList
      .flatMap(list => list.tagsCheckBoxes)
      .filter(tag => tag.isChecked)
      .map(tag => tag.businessId)
    this.tagsSelected.emit(selectedIds)
  }

  public onTagCheckChange(tag: any): void {
    tag.isChecked = !tag.isChecked
    this.emitSelectedTags()
  }
}