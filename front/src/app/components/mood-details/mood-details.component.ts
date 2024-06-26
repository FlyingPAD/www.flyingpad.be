import { Component, EventEmitter, Input, Output, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { MoodFull, UpdateMoodScoreCall } from '../../models/mood';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-mood-details',
  templateUrl: './mood-details.component.html',
  styleUrl: './mood-details.component.scss'
})
export class MoodDetailsComponent {
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
}