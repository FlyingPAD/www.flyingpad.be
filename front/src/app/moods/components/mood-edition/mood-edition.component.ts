import { Component, HostListener, inject } from '@angular/core';
import { MoodStateService } from '../../../core/services/mood-state.service';
import { environment } from '../../../../environments/environment';
import { RelationService } from '../../../core/services/client/client-relation.service';
import { RelationsMoodTagForm } from '../../../core/models/relations';
import { Router } from '@angular/router';

@Component({
  selector: 'app-mood-edition',
  templateUrl: './mood-edition.component.html',
  styleUrl: './mood-edition.component.scss'
})
export class MoodEditionComponent 
{
  // Services
  #moodService = inject(MoodStateService)
  #relationService = inject(RelationService)
  #router = inject(Router)

  // API URL
  environment : string = environment.apiBaseUrl
  
  // Signal :
  moodEditionFlow = this.#moodService.moodEditionFlow

  onSubmit()
  {
    let rmtForm : RelationsMoodTagForm = { moodId : 0, tagIds : [] }

    rmtForm.moodId = this.moodEditionFlow().mood.businessId

    this.moodEditionFlow().tagsCheckBoxes.forEach(list => {
      list.tagsCheckBoxes.forEach(tag => {
        if(tag.isChecked)
        {
          rmtForm.tagIds.push(tag.businessId)
        }
      })
    })

    this.#relationService.InsertRMT(rmtForm).subscribe({
      next : () => {
        this.#router.navigateByUrl('/moods/mood-details')
        this.#moodService.updateSelectedMoodId(rmtForm.moodId)
      }
    })
  }

  // KEYBOARD CONFIGURATION
  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    switch (event.key) 
    {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}