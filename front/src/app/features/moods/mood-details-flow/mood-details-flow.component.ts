import { Component, Input, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { MoodFull, UpdateMoodScoreCall } from '../../../models/mood';
import { FlowService } from '../../../services/flow.service';
import { Image } from '../../../models/mood-image';
import { Video } from '../../../models/mood-video';
import { VideoYouTube } from '../../../models/mood-video-youtube';

@Component({
  selector: 'app-mood-details-flow',
  templateUrl: './mood-details-flow.component.html',
  styleUrl: './mood-details-flow.component.scss'
})
export class MoodDetailsFlowComponent {
  flowService = inject(FlowService)
  
  @Input() mood! : MoodFull | undefined
  environment : string = environment.apiBaseUrl  
  
  updateMoodScore(scoreValue : number) : void
  {
    if(this.mood?.businessId != undefined)
      {
        let form : UpdateMoodScoreCall = { businessId : this.mood.businessId, value : scoreValue }
        this.flowService.updateScoreTrigger(form)
      }
  }
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

}