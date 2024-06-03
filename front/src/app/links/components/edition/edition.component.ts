import { Component, HostListener, OnDestroy, inject } from '@angular/core';
import { LinksEditionService } from '../../../core/services/links-edition.service';
import { MenuDesktopService } from '../../../core/services/menu-desktop.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { LinkCreateForm, LinkUpdateForm } from '../../../core/models/link';

@Component({
  selector: 'app-edition',
  templateUrl: './edition.component.html',
  styleUrl: './edition.component.scss'
})
export class EditionComponent implements OnDestroy
{
  #linksEditionService = inject(LinksEditionService)
  #formBuilder = inject(FormBuilder)
  menuService = inject(MenuDesktopService)            

  // Signal
  linksEditionFlow = this.#linksEditionService.linksEditionFlow

  // Pagination
  elementsPerPage : number = 18
  currentPage : number = 1
  resetPage() : void
  {
    this.currentPage = 1
  }

  // Filter Links Search Input
  searchLinks : string = ''
  filterLinks() 
  {
    return this.linksEditionFlow().links.filter(m => m.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  // Trigger Right column
  menuTrigger() : void
  {
    this.menuService.menuRActive = !this.menuService.menuRActive
  }

  // Link Selection
  updateLink( linkId : number | null ) : void
  {
    this.#linksEditionService.updateSelectedLink( linkId )
    this.triggerUpdate()
  }

  // Category Selection
  updateCategory( categoryId : number | null ) : void
  {
    this.resetPage()
    this.#linksEditionService.updateSelectedCategory( categoryId )
  }

  // CREATE MODAL
  linkTriggerCreate : boolean = false
  triggerCreate() : void
  {
    this.linkTriggerCreate = !this.linkTriggerCreate
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
    let form : LinkCreateForm = 
    {
      name : this.createFormGroup.value.name,
      description : this.createFormGroup.value.description,
      url : this.createFormGroup.value.url
    }

    if(this.createFormGroup.valid)
    {
      this.createSubscription = this.#linksEditionService.CreateLink(form).subscribe({
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
  linkTriggerUpdate : boolean = false
  triggerUpdate() : void
  {
    this.linkTriggerUpdate = !this.linkTriggerUpdate
  }
  updateFormGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.linksEditionFlow().link?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description : [this.linksEditionFlow().link?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    url : [this.linksEditionFlow().link?.url, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })
  updateSubscription = new Subscription()
  cancelUpdate()
  {
    this.triggerUpdate()
  }
  onUpdate()
  {
    const businessId = this.linksEditionFlow().link?.businessId;
    if (businessId === undefined) 
    {
      throw new Error('businessId is required but was undefined.');
    }

    let form : LinkUpdateForm = 
    {
      businessId : businessId,
      name : this.updateFormGroup.value.name,
      description : this.updateFormGroup.value.description,
      url : this.updateFormGroup.value.url
    }
    if(this.updateFormGroup.valid)
    {
      this.updateSubscription = this.#linksEditionService.UpdateLink(form).subscribe({
        next : () => 
        {
          this.triggerUpdate()
        }
      })
    }
  }

  // DELETE MODAL
  linkTriggerDelete : boolean = false
  triggerDelete() : void
  {
    this.linkTriggerDelete = !this.linkTriggerDelete
  }
  deleteSubscription = new Subscription()
  cancelDelete()
  {
    this.triggerDelete()
  }
  onDelete( linkId : number | undefined ) : void 
  {
    if(linkId === undefined) return
    this.deleteSubscription = this.#linksEditionService.DeleteLink(linkId).subscribe({
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