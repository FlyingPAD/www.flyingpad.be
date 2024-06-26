import { Component, HostListener, inject } from '@angular/core';
import { FranchisesEditionService } from '../../../services/franchises-edition.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MenuDesktopService } from '../../../services/menu-desktop.service';
import { Subscription } from 'rxjs';
import { FranchiseCreateForm } from '../../../models/franchise';

@Component({
  selector: 'app-edition',
  templateUrl: './edition.component.html',
  styleUrl: './edition.component.scss'
})
export class EditionComponent 
{
  #franchisesEditionService = inject(FranchisesEditionService)
  #formBuilder = inject(FormBuilder)
  menuService = inject(MenuDesktopService)            

  // Signal
  franchisesEditionFlow = this.#franchisesEditionService.franchisesEditionFlow

  // Pagination
  elementsPerPage : number = 18
  currentPage : number = 1
  resetPage() : void
  {
    this.currentPage = 1
  }

  // Filter franchises Search Input
  searchFranchises : string = ''
  filterFranchises() 
  {
    return this.franchisesEditionFlow().franchises.filter(m => m.name.toLowerCase().includes(this.searchFranchises.toLowerCase()))
  }

  // Trigger Right column
  menuTrigger() : void
  {
    this.menuService.menuRActive = !this.menuService.menuRActive
  }

  // Franchise Selection
  updateFranchise( franchiseId : number | null ) : void
  {
    this.#franchisesEditionService.updateSelectedFranchise( franchiseId )
    this.triggerUpdate()
  }

  // Media Selection
  updateMedia( mediaId : number | null ) : void
  {
    this.resetPage()
    this.#franchisesEditionService.updateSelectedMedia( mediaId )
  }

  // CREATE MODAL
  franchiseTriggerCreate : boolean = false
  triggerCreate() : void
  {
    this.franchiseTriggerCreate = !this.franchiseTriggerCreate
  }
  createFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
  createSubscription = new Subscription()
  resetCreate()
  {
    this.createFormGroup.reset()
    this.triggerCreate()
  }
  onCreate()
  {
    let form : FranchiseCreateForm = 
    {
      name : this.createFormGroup.value.name,
      description : this.createFormGroup.value.description
    }

    if(this.createFormGroup.valid)
    {
      this.createSubscription = this.#franchisesEditionService.CreateFranchise(form).subscribe({
        next : () => 
        {
          this.resetPage()
          this.triggerCreate()
          this.createFormGroup.reset()
        }
      })
    }
  }

  // UPDATE Modal
  franchiseTriggerUpdate : boolean = false
  triggerUpdate() : void
  {
    this.franchiseTriggerUpdate = !this.franchiseTriggerUpdate
  }
  updateFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.franchisesEditionFlow().franchise?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.franchisesEditionFlow().franchise?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
  updateSubscription = new Subscription()
  cancelUpdate()
  {
    this.triggerUpdate()
  }
  onUpdate()
  {
    let form : FranchiseCreateForm = 
    {
      name : this.updateFormGroup.value.name,
      description : this.updateFormGroup.value.description
    }
    if(this.updateFormGroup.valid)
    {
      this.updateSubscription = this.#franchisesEditionService.UpdateFranchise(form).subscribe({
        next : () => 
        {
          this.triggerUpdate()
        }
      })
    }
  }

  // DELETE MODAL
  franchiseTriggerDelete : boolean = false
  triggerDelete() : void
  {
    this.franchiseTriggerDelete = !this.franchiseTriggerDelete
  }
  deleteSubscription = new Subscription()
  cancelDelete()
  {
    this.triggerDelete()
  }
  onDelete( franchiseId : number | undefined ) : void 
  {
    if(franchiseId === undefined) return
    this.deleteSubscription = this.#franchisesEditionService.DeleteFranchise(franchiseId).subscribe({
      next : () => 
      {
        this.triggerDelete()
      }
    })
  }

  // COMPONENT LIFE CYCLE
  ngOnDestroy() : void 
  {
    this.createSubscription.unsubscribe()
    this.updateSubscription.unsubscribe()
    this.deleteSubscription.unsubscribe()
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
