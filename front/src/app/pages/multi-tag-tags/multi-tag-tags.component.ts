import { Component, HostListener, inject, OnDestroy, OnInit } from '@angular/core'
import { Router } from '@angular/router'
import { MultiTagService } from '../../services/multi-tag.service'
import { TagsCheckBoxesList } from '../../interfaces/tag'
import { NotificationService } from '../../services/user-interface/notification.service'
import { CommonTagsByMoodsForm } from '../../interfaces/mood'
import { MultiTagsForm } from '../../interfaces/http/forms-update'
import { TagService } from '../../services/http/tag.service'
import { MoodService } from '../../services/http/mood.service'
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service'
import { GalleryType } from '../../enumerations/gallery-type'
import { Subject, takeUntil } from 'rxjs'

@Component({
  selector: 'app-multi-tag-tags',
  templateUrl: './multi-tag-tags.component.html',
  styleUrls: ['./multi-tag-tags.component.scss']
})
export class MultiTagTagsComponent implements OnInit, OnDestroy {
  #multiTagService = inject(MultiTagService)
  #tagService = inject(TagService)
  #moodService = inject(MoodService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)
  #notificationService = inject(NotificationService)

  #destroy$ = new Subject<void>()

  public tagsFlow = this.#tagService.tagsFlow
  public selectedMoods = this.#multiTagService.selectedMoods

  public tagsList!: TagsCheckBoxesList[]
  private initialCommonTagIds: number[] = []

  ngOnInit(): void {
    this.initializeTagsList()
    this.fetchCommonTags()
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private initializeTagsList(): void {
    const flowData = this.tagsFlow()
    if (flowData && flowData.tagsList) {
      this.tagsList = flowData.tagsList.map(categoryGroup => ({
        category: categoryGroup.category,
        tagsCheckBoxes: categoryGroup.tags.map(tag => ({ ...tag, isChecked: false }))
      }))
    }
  }

  private fetchCommonTags(): void {
    const moodIds = this.selectedMoods()
    const form: CommonTagsByMoodsForm = { moodIds }
    this.#moodService.getCommonTagsByMoods(form)
      .pipe(takeUntil(this.#destroy$))
      .subscribe(commonTags => {
        commonTags.forEach(commonCategory => {
          const completeCategory = this.tagsList.find(tc => tc.category.businessId === commonCategory.category.businessId)
          if (completeCategory) {
            commonCategory.tagsCheckBoxes.forEach(commonTag => {
              const completeTag = completeCategory.tagsCheckBoxes.find(t => t.businessId === commonTag.businessId)
              if (completeTag) {
                completeTag.isChecked = true
                if (!this.initialCommonTagIds.includes(completeTag.businessId)) {
                  this.initialCommonTagIds.push(completeTag.businessId)
                }
              }
            })
          }
        })
      })
  }

  public onTagCheckChange(tag: any): void {
    tag.isChecked = !tag.isChecked
  }

  private getTagsToAdd(): number[] {
    return this.tagsList.flatMap(categoryGroup =>
      categoryGroup.tagsCheckBoxes
        .filter(tag => !this.initialCommonTagIds.includes(tag.businessId) && tag.isChecked)
        .map(tag => tag.businessId)
    )
  }

  private getTagsToRemove(): number[] {
    return this.tagsList.flatMap(categoryGroup =>
      categoryGroup.tagsCheckBoxes
        .filter(tag => this.initialCommonTagIds.includes(tag.businessId) && !tag.isChecked)
        .map(tag => tag.businessId)
    )
  }

  public onSubmit(): void {
    const tagsToAdd = this.getTagsToAdd()
    const tagsToRemove = this.getTagsToRemove()
    if (tagsToAdd.length === 0 && tagsToRemove.length === 0) {
      this.#notificationService.warning('No Tags Selected')
      return
    }
    const multiTagsForm: MultiTagsForm = {
      moodIds: this.selectedMoods(),
      tagsToAdd: tagsToAdd,
      tagsToRemove: tagsToRemove
    }
    this.#moodService.multiTags(multiTagsForm)
      .pipe(takeUntil(this.#destroy$))
      .subscribe(response => {
        if (response.success) {
          this.#multiTagService.resetSelection()
          this.tagsList = []
          this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
          this.#router.navigateByUrl('/central-gallery')
        }
      })
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent): void {
    switch (event.key) {
      case 'Backspace':
        this.#router.navigateByUrl('/moods/mood-manager')
        break
    }
    switch (event.key) {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}