import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { FlowService } from '../../../services/flow.service';
import { MoodsService } from '../../../services/moods.service';
import { MultiTagService } from '../../../services/multi-tag.service';
import { TagsCheckBoxesList } from '../../../interfaces/tags-list';
import { MultiTagsForm } from '../../../interfaces/forms-update';

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
  
    const multiTagsForm: MultiTagsForm = {
      moodIds: this.selectedMoods(),
      tags: selectedTagIds
    }
  
    this.#flowService.multiTags(multiTagsForm).subscribe({
      next: response => {
        if (response.success) {
          console.log('youpi');
        }
      },
      error: err => console.error(err)
    })
  
    this.#multiTagService.resetSelection()
    this.tagsList = []
    this.#moodsService.updateMoodMenuState('gallery')
    this.#router.navigateByUrl('moods')
  }  
}