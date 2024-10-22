import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { MoodFull } from '../../../interfaces/mood';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FlowService } from '../../../services/flow.service';
import { MoodScoreUpdate, MoodUpdateForm } from '../../../interfaces/forms-update';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-edition-info',
  templateUrl: './edition-info.component.html',
  styleUrl: './edition-info.component.scss'
})
export class EditionInfoComponent implements OnInit {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  @Input() mood! : MoodFull
  @Output() triggerGallery = new EventEmitter<void>()
  formGroup!: FormGroup
  moodDelete : boolean = false
  subscription : Subscription = new Subscription()

  ngOnInit(): void {
    this.formGroup = this.#formBuilder.group
    ({
      name : [this.mood.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description : [this.mood.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
  }
  updateMoodScore(scoreValue : number): void {
    let form : MoodScoreUpdate = {moodId : this.mood.businessId, value : scoreValue} 
    this.#flowService.updateScore(form)
  }

  triggerMoodDelete(): void {
    this.moodDelete = !this.moodDelete
  }
  deleteMood(): void {
    this.#flowService.DeleteMood(this.mood.businessId).subscribe(
      (response) => { if(response.success) this.triggerGallery.emit()})
  }

  onSubmit(): void {
    if (this.formGroup.valid) { 
      let form: MoodUpdateForm = {
        moodId : this.mood.businessId,
        name : this.formGroup.value.name,
        description : this.formGroup.value.description
      }
  
      this.subscription = this.#flowService.UpdateMood(form).subscribe()
    }
  }
}