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

  onSubmit(): void {
    if (this.formGroup.valid) {
      let form: MoodUpdateForm = {
        moodId: this.moodEditionFlow().mood.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description
      };
  
      this.subscription = this.#moodService.UpdateMood(form).subscribe({
        next: () => {
          this.#toastr.success('Mood was successfully updated.');
          this.updateRelations(form.moodId);
        },
        error: (error) => {
          this.handleFinalActions(false, 'Error: Mood update failed!');
        }
      });
    }
  }
  
  updateRelations(moodId: number): void {
    let rmtForm = new RelationsMoodTagForm();
    let rmaForm = new RelationsMoodArtistForm();
    let rmmForm = new RelationsMoodModelForm();
  
    rmtForm.moodId = moodId;
    rmtForm.tagIds = this.collectTagIds();
  
    rmaForm.moodId = moodId;
    rmaForm.artistIds = this.collectArtistIds();
  
    rmmForm.moodId = moodId;
    rmmForm.modelIds = this.collectModelIds();
  
    forkJoin({
      rmt: this.#relationService.InsertRMT(rmtForm),
      rma: this.#relationService.InsertRMA(rmaForm),
      rmm: this.#relationService.InsertRMM(rmmForm)
    }).subscribe({
      next: () => {
        this.handleFinalActions(true, 'All relationships successfully updated.');
      },
      error: (error) => {
        this.handleFinalActions(false, 'Error: Failed to update relationships.');
      }
    });
  }
  
  handleFinalActions(success: boolean, message: string): void {
    if (success) {
      this.#toastr.success(message);
    } else {
      this.#toastr.error(message);
    }
    this.#router.navigateByUrl('/moods/mood-details');
    if (success) {
      this.#moodService.updateSelectedMoodId(this.moodEditionFlow().mood.businessId);
    }
  }
  
  collectTagIds(): number[] {
    return this.moodEditionFlow().tagsCheckBoxes.flatMap(list => 
      list.tagsCheckBoxes.filter(tag => tag.isChecked).map(tag => tag.businessId));
  }
  
  collectArtistIds(): number[] {
    return this.moodEditionFlow().artists.filter(a => a.isChecked).map(a => a.businessId);
  }
  
  collectModelIds(): number[] {
    return this.moodEditionFlow().models.filter(m => m.isChecked).map(m => m.businessId);
  }  

  updateMoodScore( moodBusinessId : number, scoreValue : number) : void
  {
    let form : UpdateMoodScoreCall = { businessId : moodBusinessId, value : scoreValue }
    this.#moodService.updateScoreTrigger(form)
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