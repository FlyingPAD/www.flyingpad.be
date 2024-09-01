import { Component, inject, Input, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { ModelCheckBox } from '../../../models/model';
import { MoodFull } from '../../../models/mood';
import { FlowService } from '../../../services/flow.service';
import { ToastrService } from 'ngx-toastr';
import { RelationsMoodModelForm } from '../../../models/relations';

@Component({
  selector: 'app-edition-models',
  templateUrl: './edition-models.component.html',
  styleUrl: './edition-models.component.scss'
})
export class EditionModelsComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)
  #toastr = inject(ToastrService)
  @Input() mood! : MoodFull

  input : string = ''

  subscription = new Subscription()
  subscriptionRelations = new Subscription()
  models! : ModelCheckBox[]

  ngOnInit(): void {
    this.subscription = this.#flowService.getModelsCheckBoxByMood(this.mood.businessId).subscribe({
      next : data => {
        this.models = data
      }
    })
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
    this.subscriptionRelations.unsubscribe()
  }
  filterModels() {
    return this.models.filter(model => model.pseudonym.toLowerCase().includes(this.input.toLowerCase()))
  }

  onSubmit() {  
    let rmmForm : RelationsMoodModelForm = {
      moodId : this.mood.businessId, 
      modelIds : this.models.filter(model => model.isChecked).map(model => model.businessId)
    }    
  
    if (rmmForm.modelIds.length === 0) {
      this.#toastr.error('No Models selected. Please select at least one model.')
      return
    }
  
    this.subscriptionRelations = this.#flowService.InsertRMM(rmmForm).subscribe({
      next : () => {
        this.#toastr.success('Update Successfull !')
      },
      error: (error) => {
        this.#toastr.error('Failed to update Models. Please try again.')
        console.error('Error updating Models:', error)
      }
    })
  }
}