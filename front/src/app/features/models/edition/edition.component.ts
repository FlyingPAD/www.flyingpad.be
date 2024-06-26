import { Component, HostListener, inject } from '@angular/core';
import { ModelsEditionService } from '../../../services/models-edition.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { MoodStateService } from '../../../services/mood.service';
import { ModelStateService } from '../../../services/model.service';

@Component({
  selector: 'app-edition',
  templateUrl: './edition.component.html',
  styleUrl: './edition.component.scss'
})
export class EditionComponent 
{
  #modelsEditionService = inject(ModelsEditionService)
  #moodsService = inject(MoodStateService)
  #modelsService = inject(ModelStateService)
  #formBuilder = inject(FormBuilder)

  // Signal
  modelsEditionFlow = this.#modelsEditionService.modelsEditionFlow

  // Pagination
  elementsPerPage : number = 18
  currentPage : number = 1
  resetPage() : void
  {
    this.currentPage = 1
  }

  // Filter Models Search Input
  searchModels : string = ''
  filterModels() 
  {
    return this.modelsEditionFlow().filter(m => m.pseudonym.toLowerCase().includes(this.searchModels.toLowerCase()))
  }

  updateModelId( modelId : number | null ) : void
  {
    this.#modelsService.updateSelectedModelId(modelId)
    this.#moodsService.updateSelectedModelId(modelId)
  }

  // CREATE MODAL
  modelTriggerCreate : boolean = false
  triggerCreate() : void
  {
    this.modelTriggerCreate = !this.modelTriggerCreate
  }
  createFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    url : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
  createSubscription = new Subscription()
  resetCreate()
  {
    this.createFormGroup.reset()
    this.triggerCreate()
  }
  onCreate()
  {
    // let form : ModelCreateForm = 
    // {
    //   pseudonym : this.createFormGroup.value.name,
    //   description : this.createFormGroup.value.description,
    // }

    // if(this.createFormGroup.valid)
    // {
    //   this.createSubscription = this.#modelsEditionService.CreateModel(form).subscribe({
    //     next : () => 
    //     {
    //       this.resetPage()
    //       this.triggerCreate()
    //       this.createFormGroup.reset()
    //     }
    //   })
    // }
  }

  // TO TOP BUTTON
  topButtonIsActive = false    
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