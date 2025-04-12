import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { Video } from '../../../interfaces/mood-video';
import { Image } from '../../../interfaces/mood-image';
import { VideoYouTube } from '../../../interfaces/mood-video-youtube';
import { UserService } from '../../../services/http/user.service';
import { DetailedMood } from '../../../interfaces/mood';

@Component({
  selector: 'app-mood-informations',
  templateUrl: './mood-informations.component.html',
  styleUrl: './mood-informations.component.scss'
})
export class MoodInformationsComponent {
  #userService = inject(UserService)

  @Input() infoIsActive: boolean = false
  @Input() mood: DetailedMood | undefined

  
  @Output() modelId = new EventEmitter<number>()
  @Output() artistId = new EventEmitter<number>()
  @Output() franchiseId = new EventEmitter<number>()

  public user = this.#userService.user

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
}