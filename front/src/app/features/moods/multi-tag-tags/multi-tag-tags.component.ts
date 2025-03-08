import { Component, HostListener, inject, OnInit } from '@angular/core'
import { Router } from '@angular/router'
import { FlowService } from '../../../services/http/flow.service'
import { MoodsService } from '../../../services/moods.service'
import { MultiTagService } from '../../../services/multi-tag.service'
import { TagsCheckBoxesList } from '../../../interfaces/tags-list'
import { NotificationService } from '../../../services/notification.service'
import { CommonTagsByMoodsForm } from '../../../interfaces/mood'
import { MultiTagsForm } from '../../../interfaces/forms-update'

@Component({
  selector: 'app-multi-tag-tags',
  templateUrl: './multi-tag-tags.component.html',
  styleUrls: ['./multi-tag-tags.component.scss']
})
export class MultiTagTagsComponent implements OnInit {
  #flowService = inject(FlowService)
  #multiTagService = inject(MultiTagService)
  #moodsService = inject(MoodsService)
  #router = inject(Router)
  #notificationService = inject(NotificationService)

  public flow = this.#flowService.flow
  public selectedMoods = this.#multiTagService.selectedMoods
  public tagsList!: TagsCheckBoxesList[]
  private initialCommonTagIds: number[] = []

  ngOnInit(): void {
    const flowData = this.flow()
    if (flowData && flowData.tagsWithCategories) {
      this.tagsList = flowData.tagsWithCategories.map(categoryGroup => ({
        category: categoryGroup.category,
        tagsCheckBoxes: categoryGroup.tags.map(tag => ({
          ...tag,
          isChecked: false
        }))
      }))
    }
    const moodIds = this.selectedMoods()
    const form: CommonTagsByMoodsForm = { moodIds }
    this.#flowService.getCommonTagsByMoods(form).subscribe(commonTags => {
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

  public onSubmit(): void {
    const tagsToAdd = this.tagsList.flatMap(categoryGroup =>
      categoryGroup.tagsCheckBoxes.filter(tag => !this.initialCommonTagIds.includes(tag.businessId) && tag.isChecked).map(tag => tag.businessId)
    )
    const tagsToRemove = this.tagsList.flatMap(categoryGroup =>
      categoryGroup.tagsCheckBoxes.filter(tag => this.initialCommonTagIds.includes(tag.businessId) && !tag.isChecked).map(tag => tag.businessId)
    )
    if (tagsToAdd.length === 0 && tagsToRemove.length === 0) {
      this.#notificationService.warning('No Tags Selected')
    } else {
      const multiTagsForm: MultiTagsForm = {
        moodIds: this.selectedMoods(),
        tagsToAdd: tagsToAdd,
        tagsToRemove: tagsToRemove
      }
      this.#flowService.multiTags(multiTagsForm).subscribe()
      this.#multiTagService.resetSelection()
      this.tagsList = []
      this.#moodsService.updateMoodMenuState('gallery')
      this.#router.navigateByUrl('moods')
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    if (event.key === 'Enter') {
      this.onSubmit()
    }
  }
}