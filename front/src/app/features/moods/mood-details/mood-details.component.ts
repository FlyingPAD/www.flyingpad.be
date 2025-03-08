import { Component, inject, Input, EventEmitter, Output } from "@angular/core"
import { Video } from "../../../interfaces/mood-video"
import { Image } from "../../../interfaces/mood-image"
import { VideoYouTube } from "../../../interfaces/mood-video-youtube"
import { UserService } from "../../../services/http/user.service"
import { ArtistLight } from "../../../interfaces/artist"
import { FranchiseLight } from "../../../interfaces/franchise"
import { ModelLight } from "../../../interfaces/model"
import { TagLight } from "../../../interfaces/tag"
import { MoodScoreUpdate } from "../../../interfaces/forms-update"
import { MoodService } from "../../../services/http/mood.service"

@Component({
  selector: 'app-mood-details',
  templateUrl: './mood-details.component.html',
  styleUrl: './mood-details.component.scss'
})
export class MoodDetailsComponent {
  #moodService = inject(MoodService)
  #userService = inject(UserService)

  @Input() mood: any | undefined = undefined
  @Input() artists!: ArtistLight[] | undefined
  @Input() models!: ModelLight[] | undefined
  @Input() tags!: TagLight[] | undefined
  @Input() franchises!: FranchiseLight[] | undefined
  @Output() modelId = new EventEmitter<number>()
  @Output() artistId = new EventEmitter<number>()
  @Output() tagId = new EventEmitter<number>()
  @Output() franchiseId = new EventEmitter<number>()

  public user = this.#userService.user
  public infoIsActive = true

  public updateArtistId(artistId: number): void {
    this.artistId.emit(artistId)
  }
  public updateModelId(modelId: number): void {
    this.modelId.emit(modelId)
  }
  public updateFranchiseId(franchiseId: number): void {
    this.franchiseId.emit(franchiseId)
  }

  public typeCheck(media: any) {
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

  public updateMoodScore(scoreValue: number): void {
    let form: MoodScoreUpdate = { moodId: this.mood.businessId, value: scoreValue }
    this.#moodService.updateMoodScore(form)
  }
}