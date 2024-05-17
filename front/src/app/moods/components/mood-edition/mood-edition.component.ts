import { Component, HostListener, OnDestroy, inject } from '@angular/core';
import { MoodStateService } from '../../../core/services/mood.service';
import { environment } from '../../../../environments/environment';
import { RelationService } from '../../../core/services/relation.service';
import { RelationsMoodArtistForm, RelationsMoodModelForm, RelationsMoodTagForm } from '../../../core/models/relations';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MoodUpdateForm, UpdateMoodScoreCall } from '../../../core/models/mood';
import { Subscription, forkJoin } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { trigger } from '@angular/animations';

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

  // To Top Button Trigger
  topButtonIsActive = false                   

  // Subscriptions :
  EditionSubscription = new Subscription()
  EditionTagsSubscription = new Subscription()
  EditionModelsSubscription = new Subscription()
  EditionArtistsSubscription = new Subscription()
  DeleteMoodSubscription = new Subscription()

  // Triggers
  triggerMoodEdition : boolean = true
  triggerMoodTagsEdition : boolean = false
  triggerMoodModelsEdition : boolean = false
  triggerMoodArtistsEdition : boolean = false
  triggerDelete : boolean = false

  // Search
  searchModel : string = ''
  searchArtist : string = ''

  // Filter models based on search input
  filterModels() 
  {
    return this.moodEditionFlow().models.filter(m => m.pseudonym.toLowerCase().includes(this.searchModel.toLowerCase()))
  }
  // Filter artists based on search input
  filterArtists() 
  {
    return this.moodEditionFlow().artists.filter(m => m.name.toLowerCase().includes(this.searchArtist.toLowerCase()))
  }

  triggerMoodEditionButton()
  {
    this.triggerMoodEdition = true
    this.triggerMoodTagsEdition = false
    this.triggerMoodModelsEdition = false
    this.triggerMoodArtistsEdition = false
  }
  triggerMoodTagsEditionButton()
  {
    this.triggerMoodEdition = false
    this.triggerMoodTagsEdition = true
    this.triggerMoodModelsEdition = false
    this.triggerMoodArtistsEdition = false
  }
  triggerMoodArtistsEditionButton()
  {
    this.triggerMoodEdition = false
    this.triggerMoodTagsEdition = false
    this.triggerMoodModelsEdition = false
    this.triggerMoodArtistsEdition = true
  }
  triggerMoodModelsEditionButton()
  {
    this.triggerMoodEdition = false
    this.triggerMoodTagsEdition = false
    this.triggerMoodModelsEdition = true
    this.triggerMoodArtistsEdition = false
  }

  triggerDeleteMood()
  {
    this.triggerDelete = !this.triggerDelete
  }

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.moodEditionFlow().mood.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.moodEditionFlow().mood.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnDestroy() : void 
  {
    this.EditionSubscription.unsubscribe()
    this.EditionTagsSubscription.unsubscribe()
    this.EditionModelsSubscription.unsubscribe()
    this.EditionArtistsSubscription.unsubscribe()
    this.DeleteMoodSubscription.unsubscribe()
  }

  success()
  {
    this.#toastr.success('Mood was successfully updated !')
    this.#moodService.updateSelectedMoodId(this.moodEditionFlow().mood.businessId)
  }
  exit()
  {
    this.#router.navigateByUrl('/moods/mood-details')
  }

  SaveEdition( exit : boolean )
  {
    if (this.formGroup.valid) 
    {
      let form : MoodUpdateForm = 
      {
        moodId : this.moodEditionFlow().mood.businessId,
        name : this.formGroup.value.name,
        description : this.formGroup.value.description
      }
  
      this.EditionSubscription = this.#moodService.UpdateMood(form).subscribe({
        next : () => 
        {
          this.success()

          if(exit)
          {
            this.exit()
          }  
        },
        error : (error) => {
          this.#toastr.error('Mood update failed ...')
        }
      })
    }
  }

  SaveTagsEdition( exit : boolean )
  {
    let rmtForm = new RelationsMoodTagForm()

    rmtForm.moodId = this.moodEditionFlow().mood.businessId
    rmtForm.tagIds = this.moodEditionFlow().tagsCheckBoxes.flatMap(list => 
          list.tagsCheckBoxes.filter(tag => tag.isChecked).map(tag => tag.businessId))

    this.EditionTagsSubscription = this.#relationService.InsertRMT( rmtForm ).subscribe({
      next : () => 
      {
        this.success()

        if(exit)
        {
          this.exit()
        }  
      }
    })
  }

  SaveModelsEdition( exit : boolean )
  {
    let rmmForm = new RelationsMoodModelForm()
    rmmForm.moodId = this.moodEditionFlow().mood.businessId
    rmmForm.modelIds = this.moodEditionFlow().models.filter(m => m.isChecked).map(m => m.businessId);

    this.EditionModelsSubscription = this.#relationService.InsertRMM( rmmForm ).subscribe({
      next : () => 
      {
        this.success()

        if(exit)
        {
          this.exit()
        }  
      }
    })
  }
  
  SaveArtistsEdition( exit : boolean )
  {
    let rmaForm = new RelationsMoodArtistForm()
    rmaForm.moodId = this.moodEditionFlow().mood.businessId
    rmaForm.artistIds = this.moodEditionFlow().artists.filter(a => a.isChecked).map(a => a.businessId);

    this.EditionArtistsSubscription = this.#relationService.InsertRMA( rmaForm ).subscribe({
      next : () => 
      {
        this.success()

        if(exit)
        {
          this.exit()
        }  
      }
    })
  }

  updateMoodScore( moodBusinessId : number, scoreValue : number) : void
  {
    let form : UpdateMoodScoreCall = { businessId : moodBusinessId, value : scoreValue }
    this.#moodService.updateScoreTrigger(form)
  }

  deleteMood()
  {
    this.DeleteMoodSubscription = this.#moodService.Delete(this.moodEditionFlow().mood.businessId).subscribe({
      next : () => {
        this.#router.navigateByUrl('/moods/gallery')
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
        if(this.triggerMoodEdition)
          {
            this.SaveEdition(true)
          }
        if(this.triggerMoodTagsEdition)
          {
            this.SaveTagsEdition(true)
          }
        if(this.triggerMoodModelsEdition)
          {
            this.SaveModelsEdition(true)
          }
        if(this.triggerMoodArtistsEdition)
          {
            this.SaveArtistsEdition(true)
          }
        break
    }
  }

  @HostListener('window:scroll', ['$event'])
  onWindowScroll() 
  {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }

  toTop() : void 
  {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }
}