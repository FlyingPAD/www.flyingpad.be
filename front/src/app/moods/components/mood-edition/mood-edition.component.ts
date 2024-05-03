import { Component, HostListener, OnDestroy, inject } from '@angular/core';
import { MoodStateService } from '../../../core/services/mood-state.service';
import { environment } from '../../../../environments/environment';
import { RelationService } from '../../../core/services/client/client-relation.service';
import { RelationsMoodTagForm } from '../../../core/models/relations';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MoodUpdateForm } from '../../../core/models/mood';
import { Subscription } from 'rxjs';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-mood-edition',
  templateUrl: './mood-edition.component.html',
  styleUrl: './mood-edition.component.scss'
})
export class MoodEditionComponent implements OnDestroy
{
  // Services
  #moodService = inject(MoodStateService)
  #relationService = inject(RelationService)
  #formBuilder = inject(FormBuilder)
  #router = inject(Router)
  #toastr = inject(ToastrService)

  // API URL
  environment : string = environment.apiBaseUrl
  
  // Signal :
  moodEditionFlow = this.#moodService.moodEditionFlow

  // Subscription :
  subscription = new Subscription()

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.moodEditionFlow().mood.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.moodEditionFlow().mood.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnDestroy() : void 
  {
    this.subscription.unsubscribe()
  }

  onSubmit() : void 
  {
    if(this.formGroup.valid)
    {
      let form : MoodUpdateForm = 
      {
        moodId : this.moodEditionFlow().mood.businessId,
        name : this.formGroup.value.name,
        description : this.formGroup.value.description
      }

      this.subscription = this.#moodService.UpdateMood( form ).subscribe({
        next : (data) => 
          {
            this.#moodService.updateSelectedMoodId(data)
            this.#router.navigateByUrl('/moods/mood-details')
            this.#toastr.success('Mood was successfully updated.')
          },
          error: () => 
          {
            this.#router.navigateByUrl('/moods/mood-details')
            this.#toastr.error('Error : Mood update failed !')
          }
      })
    }

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