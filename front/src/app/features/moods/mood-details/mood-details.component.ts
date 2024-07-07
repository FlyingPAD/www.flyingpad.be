import { Component, inject, HostListener, OnDestroy, Input, EventEmitter, Output } from "@angular/core"
import { environment } from "../../../../environments/environment"
import { Video } from "../../../models/mood-video"
import { Image } from "../../../models/mood-image"
import { VideoYouTube } from "../../../models/mood-video-youtube"
import { UserService } from "../../../services/user.service"
import { MenuDesktopService } from "../../../services/menu-desktop.service"
import { PaginationService } from "../../../services/pagination.service"
import { ArtistLight } from "../../../models/artist"
import { FranchiseLight } from "../../../models/franchise"
import { ModelLight } from "../../../models/model"
import { TagLight } from "../../../models/tag"
import { FlowService } from "../../../services/flow.service"

@Component({
  selector: 'app-mood-details',
  templateUrl: './mood-details.component.html',
  styleUrl: './mood-details.component.scss'
})
export class MoodDetailsComponent
{
  #flowService = inject(FlowService)
  menuService = inject(MenuDesktopService)
  userService = inject(UserService)
  paginationService = inject(PaginationService)

  environment :       string          = environment.apiBaseUrl  // API URL

  moodIndexPosition : number          = 0                       // Mood Index Position ( pagination )
  flow = this.#flowService.flow
  infoIsActive = false                                          // Info Box Trigger

  @Input() mood : any | undefined = undefined
  @Input() artists! : ArtistLight[] | undefined
  @Input() models! : ModelLight[] | undefined
  @Input() tags! : TagLight[] | undefined
  @Input() franchises! : FranchiseLight[] | undefined
  @Output() modelId = new EventEmitter<number>()
  @Output() artistId = new EventEmitter<number>()
  @Output() tagId = new EventEmitter<number>()
  @Output() franchiseId = new EventEmitter<number>()

  updateArtistId(artistId: number) : void {
    this.artistId.emit(artistId)
  }
  updateModelId(modelId: number) : void {
    this.modelId.emit(modelId)
  }
  updateTagId(tagId: number) : void {
    this.tagId.emit(tagId)
  }
  updateFranchiseId(franchiseId: number) : void {
    this.franchiseId.emit(franchiseId)
  }

  // TYPE CHECK ( TEMP )
  typeCheck(media : any)
  {
    if(this.mood?.type === 1)
    {
      return media as Image
    }
    if(this.mood?.type === 2)
    {
      return media as Video
    }
    if(this.mood?.type === 4)
      {
        return media as VideoYouTube
      }
    else
    {
      return media
    }
  }

  infoTrigger()
  {
    this.infoIsActive = !this.infoIsActive
  }

  menuTrigger()
  {
    this.menuService.menuRTrigger()
  }

  updateMoodScore(scoreValue: number) : void {
    const businessId = this.mood?.businessId;
    if (businessId == null) return;
  }
}