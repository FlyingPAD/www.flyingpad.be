import { Component, HostListener, inject } from '@angular/core';
import { Router } from '@angular/router';
import { FlowService } from '../../../services/flow.service';
import { MoodsService } from '../../../services/moods.service';
import { MultiTagService } from '../../../services/multi-tag.service';
import { TagsCheckBoxesList } from '../../../interfaces/tags-list';
import { MultiTagsForm } from '../../../interfaces/forms-update';
import { NotificationService } from '../../../services/notification.service';

@Component({
  selector: 'app-multi-tag-tags',
  templateUrl: './multi-tag-tags.component.html',
  styleUrl: './multi-tag-tags.component.scss'
})
export class MultiTagTagsComponent {
  #flowService = inject(FlowService)
  #multiTagService = inject(MultiTagService)
  #moodsService = inject(MoodsService)
  #router = inject(Router)
  #notificationService = inject(NotificationService)

  public flow = this.#flowService.flow
  public selectedMoods = this.#multiTagService.selectedMoods
  public tagsList!: TagsCheckBoxesList[]

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
  }

  public onTagCheckChange(tag: any): void {
    tag.isChecked = !tag.isChecked
  }

  public onSubmit(): void {
    const selectedTagIds: number[] = this.tagsList
      .flatMap(categoryGroup =>
        categoryGroup.tagsCheckBoxes
          .filter(tag => tag.isChecked)
          .map(tag => tag.businessId)
      )

    if (selectedTagIds.length === 0) {
      this.#notificationService.warning('No Tags Selected')
    }
    else {
      const multiTagsForm: MultiTagsForm = {
        moodIds: this.selectedMoods(),
        tags: selectedTagIds
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
    switch (event.key) {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}