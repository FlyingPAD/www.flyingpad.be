import { Component, Input, inject } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { MoodFull, MoodUpdateForm, UpdateMoodScoreCall } from '../../../models/mood';
import { FlowService } from '../../../services/flow.service';
import { Image } from '../../../models/mood-image';
import { Video } from '../../../models/mood-video';
import { VideoYouTube } from '../../../models/mood-video-youtube';
import { ToastrService } from 'ngx-toastr';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-mood-details-flow',
  templateUrl: './mood-details-flow.component.html',
  styleUrl: './mood-details-flow.component.scss'
})
export class MoodDetailsFlowComponent {
  flowService = inject(FlowService)
  #toastr = inject(ToastrService)
  #formBuilder = inject(FormBuilder)
  
  @Input() mood! : MoodFull | undefined
  environment : string = environment.apiBaseUrl  
  triggerDelete : boolean = false
  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.mood?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.mood?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
  
  updateMoodScore(scoreValue : number) : void
  {
    if(this.mood?.businessId != undefined)
      {
        let form : UpdateMoodScoreCall = { businessId : this.mood.businessId, value : scoreValue }
        this.flowService.updateScore(form)
      }
  }

  update() {
    if (this.mood && this.formGroup.valid) 
    {  
      let form : MoodUpdateForm = 
      {
       moodId : this.mood?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description
      }
      this.flowService.UpdateMood(form).subscribe({
        next: () => {
          this.#toastr.success('Mood successfully updated.')
        },
        error: (error) => {
          this.#toastr.error('Error : ' + error);
        }
      })
    }
    this.formGroup.reset()
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

  deleteMood() { 
    if(this.mood)
      {
        this.flowService.DeleteMood(this.mood?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Mood successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }

  triggerDeleteMood()
  {
    this.triggerDelete = !this.triggerDelete
  }
}