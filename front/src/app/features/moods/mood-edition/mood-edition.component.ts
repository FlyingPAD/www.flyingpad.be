import { Component, HostListener, OnDestroy, inject } from '@angular/core';
import { MoodStateService } from '../../../services/mood.service';
import { environment } from '../../../../environments/environment';
import { RelationsMoodArtistForm, RelationsMoodModelForm, RelationsMoodTagForm } from '../../../models/relations';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { FlowService } from '../../../services/flow.service';
import { MoodScoreUpdate, MoodUpdateForm } from '../../../models/forms-update';

@Component({
  selector: 'app-mood-edition',
  templateUrl: './mood-edition.component.html',
  styleUrl: './mood-edition.component.scss'
})
export class MoodEditionComponent implements OnDestroy
{
  // Services
  #moodService = inject(MoodStateService)
  #flowService = inject(FlowService)
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
    name : [this.moodEditionFlow().mood?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.moodEditionFlow().mood?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnDestroy() : void 
  {
    this.EditionSubscription.unsubscribe()
    this.EditionTagsSubscription.unsubscribe()
    this.EditionModelsSubscription.unsubscribe()
    this.EditionArtistsSubscription.unsubscribe()
    this.DeleteMoodSubscription.unsubscribe()
  }

  success() {
    this.#toastr.success('Mood was successfully updated!');
    const moodId = this.moodEditionFlow().mood?.businessId;
    if (moodId != null) { this.#moodService.updateSelectedMoodId(moodId) }
  }
  exit()
  {
    this.#router.navigateByUrl('/moods/mood-details')
  }

  SaveEdition(exit: boolean) {
    if (this.formGroup.valid) {
      const mood = this.moodEditionFlow().mood;
      if (!mood || mood.businessId == null) {
        this.#toastr.error('Invalid mood data. Please try again.');
        return;
      }
  
      let form: MoodUpdateForm = {
        moodId: mood.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description
      };
  
      this.EditionSubscription = this.#moodService.UpdateMood(form).subscribe({
        next: () => {
          this.success();
          if (exit) {
            this.exit();
          }
        },
        error: (error) => {
          this.#toastr.error('Mood update failed ...');
          console.error('Error updating mood:', error);
        }
      });
    }
  }

  SaveTagsEdition(exit: boolean) {
    const mood = this.moodEditionFlow().mood;
    if (!mood || mood.businessId == null) {
      this.#toastr.error('Invalid mood data. Please check the mood details.');
      return; // Arrête l'exécution si l'objet mood est null ou si businessId est undefined
    }
  
    let rmtForm = new RelationsMoodTagForm();
    rmtForm.moodId = mood.businessId; // Utilisation sécurisée de moodId
    rmtForm.tagIds = this.moodEditionFlow().tagsCheckBoxes.flatMap(list =>
      list.tagsCheckBoxes.filter(tag => tag.isChecked).map(tag => tag.businessId));
  
    if (rmtForm.tagIds.length === 0) {
      this.#toastr.error('No tags selected. Please select at least one tag.');
      return; // Optionnel : Arrête l'exécution si aucun tag n'est sélectionné
    }
  
    this.EditionTagsSubscription = this.#flowService.InsertRMT(rmtForm).subscribe({
      next: () => {
        this.success();
        if (exit) {
          this.exit();
        }
      },
      error: (error) => {
        this.#toastr.error('Failed to update tags. Please try again.');
        console.error('Error updating tags:', error);
      }
    });
  }

  SaveModelsEdition(exit: boolean) {
    const mood = this.moodEditionFlow().mood;
    if (!mood || mood.businessId == null) {
      this.#toastr.error('Invalid mood data. Please check the mood details.');
      return; // Arrête l'exécution si l'objet mood est null ou si businessId est undefined
    }
  
    let rmmForm = new RelationsMoodModelForm();
    rmmForm.moodId = mood.businessId; // Utilisation sécurisée de moodId
    rmmForm.modelIds = this.moodEditionFlow().models.filter(m => m.isChecked).map(m => m.businessId);
  
    if (rmmForm.modelIds.length === 0) {
      this.#toastr.error('No models selected. Please select at least one model.');
      return; // Optionnel : Arrête l'exécution si aucun modèle n'est sélectionné
    }
  
    this.EditionModelsSubscription = this.#flowService.InsertRMM(rmmForm).subscribe({
      next: () => {
        this.success();
        if (exit) {
          this.exit();
        }
      },
      error: (error) => {
        this.#toastr.error('Failed to update models. Please try again.');
        console.error('Error updating models:', error);
      }
    });
  }
  
  
  SaveArtistsEdition(exit: boolean) {
    const mood = this.moodEditionFlow().mood;
    if (!mood || mood.businessId == null) {
      this.#toastr.error('Invalid mood data. Please check the mood details.');
      return; // Arrête l'exécution si l'objet mood est null ou si businessId est undefined
    }
  
    let rmaForm = new RelationsMoodArtistForm();
    rmaForm.moodId = mood.businessId; // Utilisation sécurisée de moodId
    rmaForm.artistIds = this.moodEditionFlow().artists.filter(a => a.isChecked).map(a => a.businessId);
  
    if (rmaForm.artistIds.length === 0) {
      this.#toastr.error('No artists selected. Please select at least one artist.');
      return; // Optionnel : Arrête l'exécution si aucun artiste n'est sélectionné
    }
  
    this.EditionArtistsSubscription = this.#flowService.InsertRMA(rmaForm).subscribe({
      next: () => {
        this.success();
        if (exit) {
          this.exit();
        }
      },
      error: (error) => {
        this.#toastr.error('Failed to update artists. Please try again.');
        console.error('Error updating artists:', error);
      }
    });
  }
  
  updateMoodScore(scoreValue: number): void {
    const businessId = this.moodEditionFlow().mood?.businessId;
    if (businessId == null) { // Vérifie que businessId n'est ni null ni undefined
      this.#toastr.error('Invalid mood ID. Cannot update score.');
      return; // Arrête l'exécution si businessId est null ou undefined
    }
  
    let form: MoodScoreUpdate = { businessId, value: scoreValue };
    this.#moodService.updateScoreTrigger(form);
  }

  deleteMood() {
    const moodId = this.moodEditionFlow().mood?.businessId;
    if (moodId == null) { // Vérifie que moodId n'est ni null ni undefined
      this.#toastr.error('Invalid mood ID. Cannot delete mood.');
      return; // Arrête l'exécution si moodId est null ou undefined
    }
  
    this.DeleteMoodSubscription = this.#moodService.Delete(moodId).subscribe({
      next: () => {
        this.#toastr.success('Mood successfully deleted.');
        this.#router.navigateByUrl('/moods');
      },
      error: (error) => {
        this.#toastr.error('Failed to delete mood. Please try again.');
        console.error('Error deleting mood:', error);
      }
    });
  }
  
  // KEYBOARD CONFIGURATION
  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    switch (event.key) 
    {
      case 'Enter':
        this.SaveEdition(true)
        this.SaveTagsEdition(true)
        this.SaveModelsEdition(true)
        this.SaveArtistsEdition(true)
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