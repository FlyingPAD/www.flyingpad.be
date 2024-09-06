import { Component, inject, Input, EventEmitter, Output } from "@angular/core"
import { Video } from "../../../models/mood-video"
import { Image } from "../../../models/mood-image"
import { VideoYouTube } from "../../../models/mood-video-youtube"
import { UserService } from "../../../services/user.service"
import { ArtistLight } from "../../../models/artist"
import { FranchiseLight } from "../../../models/franchise"
import { ModelLight } from "../../../models/model"
import { TagLight } from "../../../models/tag"
import { FlowService } from "../../../services/flow.service"
import { MoodScoreUpdate } from "../../../models/forms-update"

@Component({
  selector: 'app-mood-details',
  templateUrl: './mood-details.component.html',
  styleUrl: './mood-details.component.scss'
})
export class MoodDetailsComponent {
  #flowService = inject(FlowService)
  userService = inject(UserService)
  infoIsActive = true

  @Input() mood : any | undefined = undefined
  @Input() artists! : ArtistLight[] | undefined
  @Input() models! : ModelLight[] | undefined
  @Input() tags! : TagLight[] | undefined
  @Input() franchises! : FranchiseLight[] | undefined
  @Output() modelId = new EventEmitter<number>()
  @Output() artistId = new EventEmitter<number>()
  @Output() tagId = new EventEmitter<number>()
  @Output() franchiseId = new EventEmitter<number>()


  updateArtistId(artistId: number): void {
    this.artistId.emit(artistId)
  }
  updateModelId(modelId: number): void {
    this.modelId.emit(modelId)
  }
  updateFranchiseId(franchiseId: number): void {
    this.franchiseId.emit(franchiseId)
  }

  typeCheck(media : any) {
    if(this.mood?.type === 1) {
      return media as Image
    }
    if(this.mood?.type === 2) {
      return media as Video
    }
    if(this.mood?.type === 4) {
        return media as VideoYouTube
      }
    else {
      return media
    }
  }

  updateMoodScore(scoreValue : number): void {
    let form : MoodScoreUpdate = {businessId : this.mood.businessId, value : scoreValue} 
    this.#flowService.updateScore(form);
  }
}