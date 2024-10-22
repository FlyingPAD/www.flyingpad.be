import { Component, EventEmitter, Input, Output, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { MoodFull } from '../../../interfaces/mood';
import { FlowService } from '../../../services/flow.service';
import { Image } from '../../../interfaces/mood-image';
import { Video } from '../../../interfaces/mood-video';
import { VideoYouTube } from '../../../interfaces/mood-video-youtube';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ArtistLight } from '../../../interfaces/artist';
import { ModelLight } from '../../../interfaces/model';
import { TagLight } from '../../../interfaces/tag';
import { FranchiseLight } from '../../../interfaces/franchise';
import { ActivePane } from '../../../enumerations/enumerations';
import { MoodScoreUpdate, MoodUpdateForm } from '../../../interfaces/forms-update';

@Component({
  selector: 'app-mood-details-flow',
  templateUrl: './mood-details-flow.component.html',
  styleUrl: './mood-details-flow.component.scss'
})
export class MoodDetailsFlowComponent {
  @Input() mood: MoodFull | undefined = undefined
  @Input() artists: ArtistLight[] | undefined = undefined
  @Input() models: ModelLight[] | undefined = undefined
  @Input() tags: TagLight[] | undefined = undefined
  @Input() franchises: FranchiseLight[] | undefined = undefined

  @Output() modelId = new EventEmitter<number>()
  @Output() artistId = new EventEmitter<number>()
  @Output() tagId = new EventEmitter<number>()
  @Output() franchiseId = new EventEmitter<number>()

  flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  environment: string = environment.apiBaseUrl
  currentArtistId: number = 0
  currentModelId: number = 0
  currentTagId: number = 0
  currentFranchiseId: number = 0
  triggerDelete: boolean = false
  ActivePane = ActivePane
  activePane: ActivePane = ActivePane.Mood
  formGroup: FormGroup = this.#formBuilder.group
    ({
      name: [this.mood?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.mood?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })

  setActivePane(pane: ActivePane): void {
    this.activePane = pane
  }
  isPaneActive(pane: ActivePane): boolean {
    return this.activePane === pane
  }

  updateMoodScore(scoreValue: number): void {
    if (this.mood?.businessId != undefined) {
      let form: MoodScoreUpdate = { moodId: this.mood.businessId, value: scoreValue }
      this.flowService.updateScore(form)
    }
  }
  update(): void {
    if (this.mood && this.formGroup.valid) {
      let form: MoodUpdateForm =
      {
        moodId: this.mood?.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description
      }
      this.flowService.UpdateMood(form).subscribe()
    }
    this.formGroup.reset()
  }

  typeCheck(media: any) {
    if (this.mood?.type === 1) {
      return media as Image
    }
    if (this.mood?.type === 2) {
      return media as Video
    }
    if (this.mood?.type === 4) {
      return media as VideoYouTube
    }
    else {
      return media
    }
  }

  triggerDeleteMood(): void {
    this.triggerDelete = !this.triggerDelete
  }

  deleteMood(): void {
    if (this.mood) {
      this.flowService.DeleteMood(this.mood?.businessId).subscribe()
    }
  }

  handleArtistId(artistId: number): void {
    this.currentArtistId = artistId
    this.artistId.emit(artistId)
  }
  handleModelId(modelId: number): void {
    this.currentModelId = modelId
    this.modelId.emit(modelId)
  }
  handleTagId(tagId: number): void {
    this.currentTagId = tagId
    this.tagId.emit(tagId)
  }
  handleFranchiseId(franchiseId: number): void {
    this.currentFranchiseId = franchiseId
    this.franchiseId.emit(franchiseId)
  }
}