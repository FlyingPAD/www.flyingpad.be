import { Component, OnDestroy, OnInit, Output, EventEmitter, inject, HostListener } from '@angular/core'
import { Subject, takeUntil } from 'rxjs'
import { TagsCheckBoxesList } from '../../../interfaces/tag'
import { MoodService } from '../../../services/http/mood.service'
import { Router } from '@angular/router'

@Component({
  selector: 'app-edit-mood-tags',
  templateUrl: './edit-mood-tags.component.html',
  styleUrls: ['./edit-mood-tags.component.scss']
})
export class EditMoodTagsComponent implements OnInit, OnDestroy {
  #moodService = inject(MoodService)
  #router = inject(Router)

  @Output() tagsSelected = new EventEmitter<number[]>()

  #destroy$ = new Subject<void>()

  public moodsFlow = this.#moodService.moodsFlow

  public tagsList!: TagsCheckBoxesList[]  
  
  ngOnInit(): void {
    this.#moodService.getTagsCheckBoxesByMood(this.moodsFlow()?.mood.businessId)
    .pipe(takeUntil(this.#destroy$))
    .subscribe((data) => {
        this.tagsList = data
        this.emitSelectedTags()
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
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

    public backToGallery(): void { this.#router.navigateByUrl('/central-gallery') }
  
    @HostListener('window:keydown', ['$event'])
    onKeyPress(event: KeyboardEvent) {
      switch (event.key) {
        case 'Backspace':
          this.backToGallery()
          break
      }
    }
}