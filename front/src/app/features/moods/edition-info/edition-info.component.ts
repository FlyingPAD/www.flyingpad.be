import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { MoodFull } from '../../../models/mood';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FlowService } from '../../../services/flow.service';
import { MoodScoreUpdate, MoodUpdateForm } from '../../../models/forms-update';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-edition-info',
  templateUrl: './edition-info.component.html',
  styleUrl: './edition-info.component.scss'
})
export class EditionInfoComponent implements OnInit {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() mood! : MoodFull
  @Output() trigger = new EventEmitter<void>()
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
    let form : MoodScoreUpdate = {businessId : this.mood.businessId, value : scoreValue} 
    this.#flowService.updateScore(form);
  }

  triggerMoodDelete(): void {
    this.moodDelete = !this.moodDelete
  }
  deleteMood() {
    this.#flowService.DeleteMood(this.mood.businessId).subscribe({
      next : () => {
        this.#toastr.success('Mood was deleted')
        this.trigger.emit()
      }
    })
  }

  onSubmit(): void {
    if (this.formGroup.valid) { 
      let form: MoodUpdateForm = {
        moodId : this.mood.businessId,
        name : this.formGroup.value.name,
        description : this.formGroup.value.description
      }
  
      this.subscription = this.#flowService.UpdateMood(form).subscribe({
        next: () => {
          this.#toastr.success('Update Successfull !')
        },
        error: (error) => {
          this.#toastr.error('Mood update failed ...')
          console.error('Error updating mood:', error)
        }
      })
    }
  }
}